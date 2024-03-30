using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

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
        public Task<ICollection<ApplicationUser>> Listar(ICollection<ApplicationUser> empleados, ApplicationUser user)
        {
            
            var users = empleados.Where(e => e.Nombre!.ToLower().Contains(user.Nombre!.ToLower())).ToList();
            
            return Task.FromResult((ICollection<ApplicationUser>)users);
        }
        public Task<ICollection<ApplicationUser>> ListarPorCedula(ICollection<ApplicationUser> empleados, ApplicationUser user)
        {

            ApplicationUser? userTemp = empleados?.FirstOrDefault(e => e.Cedula == user.Cedula);
            if (userTemp == null)
            {
                return Task.FromResult<ICollection<ApplicationUser>>(new List<ApplicationUser>());
            }
            else
            {
                return Task.FromResult<ICollection<ApplicationUser>>(new List<ApplicationUser>() { userTemp });
            }
        }
        public Task<ICollection<ApplicationUser>?> ListarPorFecha(ICollection<ApplicationUser> empleados, DateTime FechaInicio, DateTime FechaFinal)
        {
            var users = empleados!.Where(m => m.FechaCreacion!.Date <= FechaFinal.Date && m.FechaCreacion!.Date >= FechaInicio.Date).ToList();
            return Task.FromResult((ICollection<ApplicationUser>?)users);
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
