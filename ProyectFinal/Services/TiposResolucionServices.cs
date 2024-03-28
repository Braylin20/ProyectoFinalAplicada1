using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;

namespace ProyectFinal.Services
{
    public class TiposResolucionServices(ApplicationDbContext _context)
    {

        public async Task<List<TipoResoluciones>> GetResoluciones()
        {
            return await _context!.TipoResoluciones
                .AsNoTracking().ToListAsync();
        }
        public string GetResolucion(int id)
        {
            var resolucion = _context!.TipoResoluciones.Find(id);

            return resolucion != null ? resolucion.TipoResolcion : "";
        }


    }
}
