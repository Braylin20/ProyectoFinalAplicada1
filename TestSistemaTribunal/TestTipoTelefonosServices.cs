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
    public class TestTipoTelefonosServices
    {
        [TestMethod]
        public async Task Listar_ShouldReturnListOfTipoTelefonos()
        {
            // Arrange
            var dbContextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;
            using (var context = new ApplicationDbContext(dbContextOptions))
            {
                var service = new TiposTelefonosServices(context);
                var tipoTelefono1 = new TipoTelefonos { TipoTelefonoId = 1, Descripcion = "Tipo Telefono 1" };
                var tipoTelefono2 = new TipoTelefonos { TipoTelefonoId = 2, Descripcion = "Tipo Telefono 2" };
                context.TipoTelefonos.AddRange(tipoTelefono1, tipoTelefono2);
                await context.SaveChangesAsync();

                // Act
                Expression<Func<TipoTelefonos, bool>> criterio = t => t.Descripcion.Contains("Tipo Telefono");
                var result = await service.Listar(criterio);

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(2, result.Count);
                CollectionAssert.Contains(result, tipoTelefono1);
                CollectionAssert.Contains(result, tipoTelefono2);
            }
        }
    }
}
