using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class DemandaServices(ApplicationDbContext _context)
    {
        
        public async Task<List<Demandas>> GetDemandas()
        {
            return await _context!.Demandas
                .AsNoTracking().ToListAsync();
        }

        
        public async Task<Demandas?> GetDemanda(int id)
        {
            return await _context!.Demandas.
                Include(d => d.DemandaDetalles).
                Include(d => d.UsuarioNinoDetalles).
                FirstOrDefaultAsync(d=> d.DemandaId == id);
        }
        public async Task<List<Demandas>> Listar(Expression<Func<Demandas, bool>> criterio)
        {
            return await _context.Demandas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public async Task<bool> DeleteDemanda(int id)
        {
            return await _context!.Demandas
                .AsNoTracking()
                .Where(a => a.DemandaId == id)
                .ExecuteDeleteAsync() > 0;
        }
        public async Task<bool> Save(Demandas demanda)
        {
            if (demanda.DemandaId == 0)
                _context!.Demandas.Add(demanda);
            else
                _context!.Demandas.Update(demanda);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Demandas demanda)
        {
            _context!.Update(demanda);
            _context.Entry(demanda).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
