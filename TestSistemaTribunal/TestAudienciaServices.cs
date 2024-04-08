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
    private static ApplicationDbContext GetInMemoryContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        return new ApplicationDbContext(options);
    }
    [TestMethod]
    public async Task AddObject_ShouldAddNewAudiencia()
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
    [TestMethod]
    public async Task GetAudiencias_ShouldReturnListOfAudiencias()
    {
        // Arrange
        using var context = GetInMemoryContext();
        var service = new AudienciasServices(context);
        var audiencia1 = new Audiencias { FechaAudiencia = DateTime.Now, Comentario = "Audiencia 1" };
        var audiencia2 = new Audiencias { FechaAudiencia = DateTime.Now.AddDays(-1), Comentario = "Audiencia 2" };
        context.Audiencias.AddRange(audiencia1, audiencia2);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetAudiencias();

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(2, result.Count);
        Assert.IsTrue(result.Any(a => a.FechaAudiencia == audiencia2.FechaAudiencia && a.Comentario == audiencia2.Comentario));
    }
    [TestMethod]
    public async Task DeleteAudiencia_ShouldDeleteAudiencia()
    {
        // Arrange
        using var context = GetInMemoryContext();
        var service = new AudienciasServices(context);
        var audiencia = new Audiencias { FechaAudiencia = DateTime.Now, Comentario = "Audiencia a borrar" };
        context.Audiencias.Add(audiencia);
        await context.SaveChangesAsync();

        // Act
        await service.DeleteAudiencia(audiencia.AudienciaId);
        var result = await context.Audiencias.FindAsync(audiencia.AudienciaId);

        // Assert
        Assert.IsNull(result);
    }
    [TestMethod]
    public async Task GetAudiencia_ShouldReturnAudiencia()
    {
        // Arrange
        using var context = GetInMemoryContext();
        var service = new AudienciasServices(context);
        var audiencia = new Audiencias { FechaAudiencia = DateTime.Now, Comentario = "Audiencia de prueba" };
        context.Audiencias.Add(audiencia);
        await context.SaveChangesAsync();

        // Act
        var result = await service.GetAudiencia(audiencia.AudienciaId);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(audiencia.FechaAudiencia, result.FechaAudiencia);
        Assert.AreEqual(audiencia.Comentario, result.Comentario);
    }

    [TestMethod]
    public async Task Edit_ShouldUpdateAudiencia()
    {
        // Arrange
        using var context = GetInMemoryContext();
        var service = new AudienciasServices(context);
        var audiencia = new Audiencias { FechaAudiencia = DateTime.Now, Comentario = "Audiencia original" };
        context.Audiencias.Add(audiencia);
        await context.SaveChangesAsync();

        // Act
        audiencia.Comentario = "Audiencia modificada";
        var result = await service.Edit(audiencia);

        // Assert
        Assert.IsTrue(result);
        var updatedAudiencia = await context.Audiencias.FindAsync(audiencia.AudienciaId);
        Assert.IsNotNull(updatedAudiencia);
        Assert.AreEqual("Audiencia modificada", updatedAudiencia.Comentario);
    }

}
