using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class AlguacilServices(ApplicationDbContext _context)
    {
        public async Task<List<Alguaciles>> Listar(Expression<Func<Alguaciles, bool>> criterio)
        {
            return await _context.Alguaciles
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
    }
    
}
