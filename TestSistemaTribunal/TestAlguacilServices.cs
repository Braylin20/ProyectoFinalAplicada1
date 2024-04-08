using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using ProyectFinal.Services;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSistemaTribunal
{
    [TestClass]
    public class TestAlguacilServices
    {
        private static ApplicationDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }


        [TestMethod]
        public async Task AddObject_ShouldAddNewAlguacil()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            var dbContext = new ApplicationDbContext(options);
            var alguacilServices = new AlguacilServices(dbContext);
            // Act
            var nuevoAlguacil = new Alguaciles
            {
                FechaCreacion = DateTime.Now,
                Nombre = "Eliezer",
                Apellido = "Terrero",
            };
            var resultado = await alguacilServices.Save(nuevoAlguacil);

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public async Task Listar_MostrarAlguaciles()
        {

            // Arrange
            using var context = GetInMemoryContext();
            var service = new AlguacilServices(context);
            var alguacil1 = new Alguaciles { Nombre = "Juan", Apellido = "Pérez", FechaCreacion = DateTime.Now };
            var alguacil2 = new Alguaciles { Nombre = "María", Apellido = "Gómez", FechaCreacion = DateTime.Now.AddDays(-1) };
            context.Alguaciles.AddRange(alguacil1, alguacil2);
            await context.SaveChangesAsync();

            // Act
            var result = await service.GetAlguaciles();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.IsTrue(result.Any(a => a.Nombre == alguacil1.Nombre && a.Apellido == alguacil1.Apellido));
            Assert.IsTrue(result.Any(a => a.Nombre == alguacil2.Nombre && a.Apellido == alguacil2.Apellido));
        }

        [TestMethod]
        public async Task getAlguacil_ShowAlguacil_Especific()
        {
            // Arrange
            using var context = GetInMemoryContext();
            var service = new AlguacilServices(context);
            var alguacil1 = new Alguaciles { AlguacilId = 1, Nombre = "Juan", Apellido = "Pérez", FechaCreacion = DateTime.Now };
            var alguacil2 = new Alguaciles { AlguacilId = 2, Nombre = "María", Apellido = "Gómez", FechaCreacion = DateTime.Now.AddDays(-1) };
            context.Alguaciles.AddRange(alguacil1, alguacil2);
            await context.SaveChangesAsync();

            // Act
            var result = await service.GetAlguacil(1); // Obtener alguacil con ID 1

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Juan", result.Nombre);
            Assert.AreEqual("Pérez", result.Apellido);
        }

        [TestMethod]
        public async Task DeleteAlguacil_ShouldRemoveAlguacil()
        {
            // Arrange
            using var context = GetInMemoryContext();
            var service = new AlguacilServices(context);
            var alguacil = new Alguaciles { AlguacilId = 1, Nombre = "Juan", Apellido = "Pérez", FechaCreacion = DateTime.Now };
            context.Alguaciles.Add(alguacil);
            await context.SaveChangesAsync();

            // Act
            await service.DeleteAlguacil(alguacil.AlguacilId);

            // Assert
            var deletedAlguacil = await context.Alguaciles.FindAsync(1);
            Assert.IsNull(deletedAlguacil);
        }
    }
}
