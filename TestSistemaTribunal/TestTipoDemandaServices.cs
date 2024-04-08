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
    public class TestTipoDemandaServices
    {
        private static ApplicationDbContext GetInMemoryContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            return new ApplicationDbContext(options);
        }

        [TestMethod]

        public async Task Listar_TiposDemandas_ShouldReturnListOfTiposDemandas()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;
            var dbContext = new ApplicationDbContext(options);
            var service = new TipoDemandaServices(dbContext);

           
            var tiposDemandas = new List<TiposDemandas>
            {
                new TiposDemandas { TiposDemandasId = 1, TipoDemanda = "Tipo Demanda 1" },
                new TiposDemandas { TiposDemandasId = 2, TipoDemanda = "Tipo Demanda 2" },
                new TiposDemandas { TiposDemandasId = 3, TipoDemanda = "Tipo Demanda 3" }
            };
            dbContext.TiposDemandas.AddRange(tiposDemandas);
            await dbContext.SaveChangesAsync();

            // Act
            var result = await service.Listar();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(tiposDemandas.Count, result.Count);
            foreach (var tipoDemanda in tiposDemandas)
            {
                Assert.IsTrue(result.Any(td => td.TiposDemandasId == tipoDemanda.TiposDemandasId && td.TipoDemanda == tipoDemanda.TipoDemanda));
            }
        }


        [TestMethod]
        public async Task GetTipoDemanda_ShouldReturnTipoDemanda()
        {
            // Arrange
            using var context = GetInMemoryContext();
            var service = new TipoDemandaServices(context);
            var tipoDemanda1 = new TiposDemandas { TiposDemandasId = 1, TipoDemanda = "Divorcio" };
            var tipoDemanda2 = new TiposDemandas { TiposDemandasId = 2, TipoDemanda = "Custodia" };
            context.TiposDemandas.AddRange(tipoDemanda1, tipoDemanda2);
            await context.SaveChangesAsync();

            // Act
            var result = service.GetTipoDemanda(1); // Obtener tipo de demanda con ID 1

            // Assert
            Assert.AreEqual("Divorcio", result);
        }
    }
}
