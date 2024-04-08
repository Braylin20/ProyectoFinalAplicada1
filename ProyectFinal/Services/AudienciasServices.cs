using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;
namespace ProyectFinal.Services
{
    public class AudienciasServices(ApplicationDbContext _context)
    {
        public async Task<List<Audiencias>> GetAudiencias()
        {
            return await _context!.Audiencias.AsNoTracking().ToListAsync();
        }

        public async Task<Audiencias?> GetAudiencia(int id)
        {
            return await _context!.Audiencias.FindAsync(id);
        }
        public async Task<bool> DeleteAudiencia(int id)
        {
            var audienciaToDelete = await _context.Audiencias.FindAsync(id);

            if (audienciaToDelete == null)
            {
                return false; 
            }
            var demandasConAudiencia = await _context.Demandas
                .Where(d => d.AudienciaId == id)
                .ToListAsync();

            foreach (var demanda in demandasConAudiencia)
            {
                demanda.Audiencia = null;
            }
            await _context.SaveChangesAsync();
            _context.Audiencias.Remove(audienciaToDelete);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<List<Audiencias>> Listar(Expression<Func<Audiencias, bool>> criterio)
        {
            return await _context.Audiencias
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public async Task<bool> Save(Audiencias audiencias)
        {
            if(audiencias.AudienciaId == 0)
                _context!.Audiencias.Add(audiencias);

            else
                _context!.Audiencias.Update(audiencias);
            
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Audiencias audiencia)
        {
            _context!.Update(audiencia);
            _context.Entry(audiencia).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
