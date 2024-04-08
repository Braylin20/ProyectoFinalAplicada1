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
    public class TestTiposResolucionesServices
    {
        [TestClass]
        public class TiposResolucionServicesTests
        {
            [TestMethod]
            public async Task GetResoluciones_ShouldReturnListOfResoluciones()
            {
                // Arrange
                var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;
                using (var context = new ApplicationDbContext(dbContextOptions))
                {
                    var service = new TiposResolucionServices(context);
                    var resolucion1 = new TipoResoluciones { ResolucionId = 1, TipoResolcion = "Resolucion 1" };
                    var resolucion2 = new TipoResoluciones { ResolucionId = 2, TipoResolcion = "Resolucion 2" };
                    context.TipoResoluciones.AddRange(resolucion1, resolucion2);
                    await context.SaveChangesAsync();

                    // Act
                    var result = await service.GetResoluciones();

                    // Assert
                    Assert.IsNotNull(result);
                    Assert.AreEqual(2, result.Count);
                    CollectionAssert.Contains(result, resolucion1);
                    CollectionAssert.Contains(result, resolucion2);
                }
            }

            [TestMethod]
            public void GetResolucion_ShouldReturnResolucionString()
            {
                // Arrange
                var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                    .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                    .Options;
                using (var context = new ApplicationDbContext(dbContextOptions))
                {
                    var service = new TiposResolucionServices(context);
                    var resolucion = new TipoResoluciones { ResolucionId = 1, TipoResolcion = "Resolucion de Prueba" };
                    context.TipoResoluciones.Add(resolucion);
                    context.SaveChanges();

                    // Act
                    var result = service.GetResolucion(resolucion.ResolucionId);

                    // Assert
                    Assert.AreEqual(resolucion.TipoResolcion, result);
                }
            }
        }
    }
}
