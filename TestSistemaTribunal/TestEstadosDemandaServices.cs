using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using ProyectFinal.Services;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestSistemaTribunal
{
    [TestClass]
    public class TestEstadosDemandaServices
    {
        [TestMethod]
        public async Task Listar_DeberiaDevolverEstadosQueCumplanCriterio()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new EstadoServices(context);
                var estados = new List<EstadosDemandas>
                {
                    new EstadosDemandas { EstadoId = 1, Estado = "Activo" },
                    new EstadosDemandas { EstadoId = 2, Estado = "Inactivo" },
                    new EstadosDemandas { EstadoId = 3, Estado = "En Espera" }
                };
                context.EstadosDemandas.AddRange(estados);
                context.SaveChanges();

                Expression<Func<EstadosDemandas, bool>> criterio = estado => estado.Estado == "Activo";

                // Act
                var result = await service.Listar(criterio);

                // Assert
                Assert.AreEqual(1, result.Count);
                Assert.AreEqual("Activo", result.First().Estado);
            }
        }
    }
}
