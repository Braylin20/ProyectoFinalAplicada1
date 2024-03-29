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


        public async Task<List<Alguaciles>> GetAlguaciles()
        {
            return await _context!.Alguaciles.AsNoTracking().ToListAsync();
        }

        public async Task<Alguaciles?> GetAlguacil(int id)
        {
            return await _context!.Alguaciles.FindAsync(id);
        }
        public async Task<bool> DeleteAlguacil(int id)
        {
            return await _context!.Alguaciles
                .AsNoTracking()
                .Where(a => a.AlguacilId == id)
                .ExecuteDeleteAsync() > 0;

        }
       
        public async Task<bool> Save(Alguaciles alguacil)
        {
            if (alguacil.AlguacilId == 0)
                _context!.Alguaciles.Add(alguacil);
            else
                _context!.Alguaciles.Update(alguacil);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Alguaciles Alguacil)
        {
            _context!.Update(Alguacil);
            _context.Entry(Alguacil).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }
    }
    
}
