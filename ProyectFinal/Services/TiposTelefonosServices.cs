using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class TiposTelefonosServices(ApplicationDbContext _context)
    {
        public async Task<List<TipoTelefonos>> Listar(Expression<Func<TipoTelefonos, bool>> criterio)
        {
            return await _context.TipoTelefonos
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
