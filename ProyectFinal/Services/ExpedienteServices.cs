using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class ExpedienteServices(ApplicationDbContext _context)
    {
        public async Task<List<Expedientes>> GetExpedientes()
        {
            return await _context!.Expedientes
                .AsNoTracking().ToListAsync();
        }
        public async Task<Expedientes?> GetExpediente(int id)
        {
            return await _context!.Expedientes.FindAsync(id);
        }

        public async Task<bool> Save(Expedientes expediente)
        {
            if (expediente.ExpedienteId == 0)
                _context!.Expedientes.Add(expediente);
            else
                _context!.Expedientes.Update(expediente);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Expedientes expediente)
        {
            _context!.Update(expediente);
            _context.Entry(expediente).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
