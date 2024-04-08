using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using ProyectFinal.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSistemaTribunal
{
    [TestClass]
    public class TestEmpleadoServices
    {
        [TestMethod]
        public void Listar_DeberiaFiltrarEmpleadosPorNombre()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new EmpleadoServices(context);
                var empleados = new List<ApplicationUser>
                {
                    new ApplicationUser { Id = "1", Nombre = "Juan", Apellido = "Perez" },
                    new ApplicationUser { Id = "2", Nombre = "Maria", Apellido = "Gomez" }
                };
                context.Users.AddRange(empleados);
                context.SaveChanges();

                var user = new ApplicationUser { Nombre = "Juan" };

                // Act
                var result = service.Listar(empleados, user).Result;

                // Assert
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual("Juan", result.First().Nombre);
            }
        }

        [TestMethod]
        public void ListarPorCedula_DeberiaBuscarEmpleadoPorCedula()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new EmpleadoServices(context);
                var empleados = new List<ApplicationUser>
                {
                    new ApplicationUser { Id = "1", Nombre = "Juan", Apellido = "Perez", Cedula = 12345678901 },
                    new ApplicationUser { Id = "2", Nombre = "Maria", Apellido = "Gomez", Cedula = 98765432109 }
                };
                context.Users.AddRange(empleados);
                context.SaveChanges();

                var user = new ApplicationUser { Cedula = 12345678901 };

                // Act
                var result = service.ListarPorCedula(empleados, user).Result;

                // Assert
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual(12345678901, result.First().Cedula);
            }
        }

        [TestMethod]
        public void ListarPorFecha_DeberiaFiltrarEmpleadosPorFechaDeCreacion()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new EmpleadoServices(context);
                var fechaInicio = new DateTime(2024, 1, 1);
                var fechaFinal = new DateTime(2024, 1, 3);
                var empleados = new List<ApplicationUser>
                {
                    new ApplicationUser { Id = "1", Nombre = "Juan", Apellido = "Perez", FechaCreacion = fechaInicio },
                    new ApplicationUser { Id = "2", Nombre = "Maria", Apellido = "Gomez", FechaCreacion = fechaFinal.AddDays(1) }
                };
                context.Users.AddRange(empleados);
                context.SaveChanges();

                // Act
                var result = service.ListarPorFecha(empleados, fechaInicio, fechaFinal).Result;

                // Assert
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual(fechaInicio.Date, result.First().FechaCreacion.Date);
            }
        }
    }
}
