using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class UsuarioExpedienteServices(ApplicationDbContext _context)
    {
        public async Task<bool> DeleteUsuarioExpediente(int id)
        {
            return await _context!.UsuarioExpedienteDetalle
                .AsNoTracking()
                .Where(a => a.DetalleId == id)
                .ExecuteDeleteAsync() > 0;

        }
        public async Task<List<UsuarioExpedienteDetalle>> Listar(Expression<Func<UsuarioExpedienteDetalle, bool>> criterio)
        {
            return await _context.UsuarioExpedienteDetalle
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public async Task<bool> Save(UsuarioExpedienteDetalle UsuarioExpedienteDetalle)
        {
            if (UsuarioExpedienteDetalle.DetalleId == 0)
                _context!.UsuarioExpedienteDetalle.Add(UsuarioExpedienteDetalle);

            else
                _context!.UsuarioExpedienteDetalle.Update(UsuarioExpedienteDetalle);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
