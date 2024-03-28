using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class TipoDemandaServices(ApplicationDbContext _context)
    {
        public async Task<List<TiposDemandas>> Listar(Expression<Func<TiposDemandas, bool>> criterio)
        {
            return await _context.TiposDemandas
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }

        public string GetTipoDemanda(int? id)
        {
            var resolucion = _context!.TiposDemandas.Find(id);

            return resolucion != null ? resolucion.TipoDemanda : "";
        }

    }
}
