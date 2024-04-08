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
    public class TestExpedienteServices
    {
        [TestMethod]
        public async Task Save_ShouldAddNewExpediente()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new ExpedienteServices(context);
                var expediente = new Expedientes
                {
                    SentenciaId = 1,
                    Id = "user123",
                    DemandaId = 1,
                    Comentario = "Comentario de prueba",
                    FechaCreacion = DateTime.Now
                };

                // Act
                var result = await service.Save(expediente);

                // Assert
                Assert.IsTrue(result);
                Assert.AreEqual(1, context.Expedientes.Count());
                var addedExpediente = context.Expedientes.First();
                Assert.AreEqual(expediente.SentenciaId, addedExpediente.SentenciaId);
                Assert.AreEqual(expediente.Id, addedExpediente.Id);
                Assert.AreEqual(expediente.DemandaId, addedExpediente.DemandaId);
                Assert.AreEqual(expediente.Comentario, addedExpediente.Comentario);
                Assert.AreEqual(expediente.FechaCreacion, addedExpediente.FechaCreacion);
            }
        }

        [TestMethod]
        public async Task Edit_ShouldUpdateExpediente()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new ExpedienteServices(context);
                var expediente = new Expedientes
                {
                    SentenciaId = 1,
                    Id = "user123",
                    DemandaId = 1,
                    Comentario = "Comentario original",
                    FechaCreacion = DateTime.Now
                };
                context.Expedientes.Add(expediente);
                await context.SaveChangesAsync();

                // Act
                expediente.Comentario = "Comentario modificado";
                var result = await service.Edit(expediente);

                // Assert
                Assert.IsTrue(result);
                var updatedExpediente = await context.Expedientes.FindAsync(expediente.ExpedienteId);
                Assert.IsNotNull(updatedExpediente);
                Assert.AreEqual("Comentario modificado", updatedExpediente.Comentario);
            }
        }

        [TestMethod]
        public async Task GetExpedientes_ShouldReturnListOfExpedientes()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new ExpedienteServices(context);
                context.Expedientes.AddRange(
                    new Expedientes { SentenciaId = 1, Id = "user123", DemandaId = 1, Comentario = "Comentario 1", FechaCreacion = DateTime.Now },
                    new Expedientes { SentenciaId = 2, Id = "user456", DemandaId = 2, Comentario = "Comentario 2", FechaCreacion = DateTime.Now }
                );
                await context.SaveChangesAsync();

                // Act
                var result = await service.GetExpedientes();

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(2, result.Count);
            }
        }

        [TestMethod]
        public async Task GetExpediente_ShouldReturnExpediente()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new ExpedienteServices(context);
                var expediente = new Expedientes
                {
                    SentenciaId = 1,
                    Id = "user123",
                    DemandaId = 1,
                    Comentario = "Comentario de prueba",
                    FechaCreacion = DateTime.Now
                };
                context.Expedientes.Add(expediente);
                await context.SaveChangesAsync();

                // Act
                var result = await service.GetExpediente(expediente.ExpedienteId);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(expediente.SentenciaId, result.SentenciaId);
                Assert.AreEqual(expediente.Id, result.Id);
                Assert.AreEqual(expediente.DemandaId, result.DemandaId);
                Assert.AreEqual(expediente.Comentario, result.Comentario);
                Assert.AreEqual(expediente.FechaCreacion, result.FechaCreacion);
            }
        }
    
    }
}
