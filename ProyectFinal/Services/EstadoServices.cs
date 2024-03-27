using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class EstadoServices(ApplicationDbContext _context)
    {
        public async Task<List<EstadosDemandas>> Listar(Expression<Func<EstadosDemandas, bool>> criterio)
        {
            return await _context.EstadosDemandas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
}
