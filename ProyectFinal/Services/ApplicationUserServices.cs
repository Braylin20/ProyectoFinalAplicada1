﻿using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class ApplicationUserServices(ApplicationDbContext _context)
    {
        
        
        public async Task<ApplicationUser?> GetUser(string id)
        {
            return _context.Users.Include(u => u.TelefonoDetalles).FirstOrDefault(t => t.Id == id);
        }
        public ApplicationUser ObtenerEmpleadoDestacado()
        {
            return _context.Users.OrderByDescending(u => u.ContadorSentencias).FirstOrDefault();
        }
        public async Task<List<ApplicationUser>> Listar(Expression<Func<ApplicationUser, bool>> criterio)
        {
            return await _context.Users
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public  ApplicationUser GetUserByCedula(long? cedula)
        {
            var user= _context.Users.Include(u => u.TelefonoDetalles).FirstOrDefault(t => t.Cedula == cedula);
            return user;
        }
        public async Task<bool> Update(ApplicationUser user)
        {
            _context!.Users.Update(user);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task SaveChanges(ApplicationUser user)
        {
            _context!.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> Delete(string id)
        {
            return await _context!.Users
                .AsNoTracking()
                .Where(a => a.Id == id)
                .ExecuteDeleteAsync() > 0;
        }
    }
}
