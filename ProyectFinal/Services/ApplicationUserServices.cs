using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;

namespace ProyectFinal.Services
{
    public class ApplicationUserServices(ApplicationDbContext _context)
    {
        public async Task<bool> Save(TelefonoDetalles telefono)
        {
            _context!.TelefonoDetalles.Add(telefono);
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<ApplicationUser?> GetUser(string id)
        {
            return _context.Users.Include(u => u.TelefonoDetalles).FirstOrDefault(t=>t.Id == id);
        }
        public async Task<bool> Update(ApplicationUser user)
        {
            _context!.Users.Update(user);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
