using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class EmpleadoServices(ApplicationDbContext _context)
    {

        public async Task<bool> Delete(int id)
        {
            return await _context!.Empleados
                .AsNoTracking()
                .Where(a => a.EmpleadoId == id)
                .ExecuteDeleteAsync() > 0;
        }
        public async Task<List<Empleados>> Listar(Expression<Func<Empleados, bool>> criterio)
        {
            return await _context.Empleados
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public async Task<bool> Save(Empleados empleado)
        {
            if (empleado.EmpleadoId == 0)
                _context!.Empleados.Add(empleado);
            else
                _context!.Empleados.Update(empleado);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Empleados empleado)
        {
            _context!.Update(empleado);
            _context.Entry(empleado).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
