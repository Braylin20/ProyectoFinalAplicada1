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
    public class TestDemandaServices
    {
        private static ApplicationDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }

        [TestMethod]
        public async Task Save_ShouldAddNewDemanda()
        {
            // Arrange
            using var context = GetInMemoryContext();
            var service = new DemandaServices(context);
            var nuevaDemanda = new Demandas
            {
                TiposDemandasId = 1,
                EstadoId = 1,
                AlguacilId = 1,
                Cedula = 12345678901,
                AudienciaId = 1,
                Documento = new byte[] { 0x00, 0x01, 0x02 },
                FotoCedula = new byte[] { 0x03, 0x04, 0x05 },
                Fecha = DateTime.Now,
                Descripcion = "Nueva demanda de prueba"
            };

            // Act
            var resultado = await service.Save(nuevaDemanda);

            // Assert
            Assert.IsTrue(resultado);
            var demandaGuardada = await context.Demandas.FirstOrDefaultAsync(d => d.DemandaId == nuevaDemanda.DemandaId);
            Assert.IsNotNull(demandaGuardada);
            Assert.AreEqual(nuevaDemanda.TiposDemandasId, demandaGuardada.TiposDemandasId);
            Assert.AreEqual(nuevaDemanda.EstadoId, demandaGuardada.EstadoId);
            Assert.AreEqual(nuevaDemanda.AlguacilId, demandaGuardada.AlguacilId);
            Assert.AreEqual(nuevaDemanda.Cedula, demandaGuardada.Cedula);
            Assert.AreEqual(nuevaDemanda.AudienciaId, demandaGuardada.AudienciaId);
            Assert.AreEqual(nuevaDemanda.Documento, demandaGuardada.Documento);
            Assert.AreEqual(nuevaDemanda.FotoCedula, demandaGuardada.FotoCedula);
            Assert.AreEqual(nuevaDemanda.Fecha, demandaGuardada.Fecha);
            Assert.AreEqual(nuevaDemanda.Descripcion, demandaGuardada.Descripcion);
        }

        [TestMethod]
        public async Task DeleteDemanda_ShouldDeleteDemanda()
        {
            // Arrange
            using var context = GetInMemoryContext();
            var service = new DemandaServices(context);
            var demanda = new Demandas
            {
                TiposDemandasId = 1,
                EstadoId = 1,
                AlguacilId = 1,
                Cedula = 12345678901,
                AudienciaId = 1,
                Documento = new byte[] { 0x00, 0x01, 0x02 },
                FotoCedula = new byte[] { 0x03, 0x04, 0x05 },
                Fecha = DateTime.Now,
                Descripcion = "Demanda a borrar"
            };
            context.Demandas.Add(demanda);
            await context.SaveChangesAsync();

            // Act
            await service.DeleteDemanda(demanda.DemandaId);
            var result = await context.Demandas.FindAsync(demanda.DemandaId);

            // Assert
            Assert.IsNull(result);
        }
    }
}

