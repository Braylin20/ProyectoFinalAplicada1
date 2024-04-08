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
    public class TestSentenciaServices
    {
        [TestMethod]
        public async Task Save_ShouldAddNewSentencia()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new SentenciaServices(context);
                var sentencia = new Sentencias
                {
                    DemandaId = 1,
                    ResolucionId = 1,
                    Sentencia = new byte[] { 0x00, 0x01, 0x02 },
                    NombreMinisterio = "Ministerio de Prueba",
                    FechaCreacion = DateTime.Now
                };

                // Act
                var result = await service.Save(sentencia);

                // Assert
                Assert.IsTrue(result);
                Assert.AreEqual(1, context.Sentencias.Count());
                var addedSentencia = context.Sentencias.First();
                Assert.AreEqual(sentencia.DemandaId, addedSentencia.DemandaId);
                Assert.AreEqual(sentencia.ResolucionId, addedSentencia.ResolucionId);
                CollectionAssert.AreEqual(sentencia.Sentencia, addedSentencia.Sentencia);
                Assert.AreEqual(sentencia.NombreMinisterio, addedSentencia.NombreMinisterio);
                Assert.AreEqual(sentencia.FechaCreacion, addedSentencia.FechaCreacion);
            }
        }

        [TestMethod]
        public async Task Edit_ShouldUpdateSentencia()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new SentenciaServices(context);
                var sentencia = new Sentencias
                {
                    DemandaId = 1,
                    ResolucionId = 1,
                    Sentencia = new byte[] { 0x00, 0x01, 0x02 },
                    NombreMinisterio = "Ministerio original",
                    FechaCreacion = DateTime.Now
                };
                context.Sentencias.Add(sentencia);
                await context.SaveChangesAsync();

                // Act
                sentencia.NombreMinisterio = "Ministerio modificado";
                var result = await service.Edit(sentencia);

                // Assert
                Assert.IsTrue(result);
                var updatedSentencia = await context.Sentencias.FindAsync(sentencia.SentenciaId);
                Assert.IsNotNull(updatedSentencia);
                Assert.AreEqual("Ministerio modificado", updatedSentencia.NombreMinisterio);
            }
        }

        [TestMethod]
        public async Task GetSentencia_ShouldReturnSentencia()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new SentenciaServices(context);
                var sentencia = new Sentencias
                {
                    DemandaId = 1,
                    ResolucionId = 1,
                    Sentencia = new byte[] { 0x00, 0x01, 0x02 },
                    NombreMinisterio = "Ministerio de Prueba",
                    FechaCreacion = DateTime.Now
                };
                context.Sentencias.Add(sentencia);
                await context.SaveChangesAsync();

                // Act
                var result = await service.GetSentencia(sentencia.SentenciaId);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(sentencia.DemandaId, result.DemandaId);
                Assert.AreEqual(sentencia.ResolucionId, result.ResolucionId);
                CollectionAssert.AreEqual(sentencia.Sentencia, result.Sentencia);
                Assert.AreEqual(sentencia.NombreMinisterio, result.NombreMinisterio);
                Assert.AreEqual(sentencia.FechaCreacion, result.FechaCreacion);
            }
        }

        [TestMethod]
        public async Task Delete_ShouldDeleteSentencia()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new SentenciaServices(context);
                var sentencia = new Sentencias
                {
                    DemandaId = 1,
                    ResolucionId = 1,
                    Sentencia = new byte[] { 0x00, 0x01, 0x02 },
                    NombreMinisterio = "Ministerio de Prueba",
                    FechaCreacion = DateTime.Now
                };
                context.Sentencias.Add(sentencia);
                await context.SaveChangesAsync();

                // Act
                await service.Delete(sentencia.SentenciaId);
                var result = await context.Sentencias.FindAsync(sentencia.SentenciaId);

                // Assert
                Assert.IsNull(result);
            }
        }
    }
}
