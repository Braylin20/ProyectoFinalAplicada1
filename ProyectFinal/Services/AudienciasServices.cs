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
            return await _context!.Audiencias
                .AsNoTracking()
                .Where(a => a.AudienciaId == id)
                .ExecuteDeleteAsync() > 0;
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
