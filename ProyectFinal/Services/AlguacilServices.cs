using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class AlguacilServices(ApplicationDbContext _context)
    {
     

        public async Task<List<Alguaciles>> GetAlguaciles()
        {
            return await _context!.Alguaciles.AsNoTracking().ToListAsync();
        }

        public async Task<Alguaciles?> GetAlguacil(int id)
        {
            return await _context!.Alguaciles.FindAsync(id);
        }
        public async Task DeleteAlguacil(int id)
        {
            var alguacil = await _context.Alguaciles.FindAsync(id);
            if (alguacil != null)
            {
                _context.Alguaciles.Remove(alguacil);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> Save(Alguaciles alguacil)
        {
            if (alguacil.AlguacilId == 0)
                _context!.Alguaciles.Add(alguacil);
            else
                _context!.Alguaciles.Update(alguacil);

            return await _context.SaveChangesAsync() > 0;
        }
    }
    
}
