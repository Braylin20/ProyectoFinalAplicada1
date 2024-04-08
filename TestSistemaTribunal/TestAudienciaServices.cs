using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProyectFinal.Data;
using ProyectFinal.Services;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace TestSistemaTribunal;

[TestClass]
public class TestAudienciaServices
{
    [TestMethod]
    public async Task AddObject_ShouldAddNewAbonos()
    {
            //Arrange
       var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "TestDatabase")
           .Options;
        var dbContext = new ApplicationDbContext(options);
        var audienciaService = new AudienciasServices(dbContext);
        // Act
        var nuevaAudiencia = new Audiencias
        {
            FechaAudiencia = DateTime.Now,
            Comentario = "Comentario de prueba"
        };
        var resultado = await audienciaService.Save(nuevaAudiencia);

        //Assert
        Assert.IsTrue(resultado); 
    }
}
