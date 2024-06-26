﻿using Microsoft.EntityFrameworkCore;
using ProyectFinal.Data;
using Share.Models;
using System.Linq.Expressions;

namespace ProyectFinal.Services
{
    public class SentenciaServices(ApplicationDbContext _context)
    {

        public async Task<Sentencias?> GetSentencia(int id)
        {
            return await _context.Sentencias.FindAsync(id);

        }
        public async Task<bool> Delete(int id)
        {
            return await _context!.Sentencias
                .AsNoTracking()
                .Where(a => a.SentenciaId == id)
                .ExecuteDeleteAsync() > 0;
        }
        public async Task<List<Sentencias>> Listar(Expression<Func<Sentencias, bool>> criterio)
        {
            return await _context.Sentencias
                .AsNoTracking()
                .Where(criterio)
                .ToListAsync();
        }
        public async Task<bool> Save(Sentencias sentencia)
        {
            if (sentencia.SentenciaId == 0)
                _context!.Sentencias.Add(sentencia);
            else
                _context!.Sentencias.Update(sentencia);

            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Edit(Sentencias sentencia)
        {
            _context!.Update(sentencia);
            _context.Entry(sentencia).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<List<int>> GetSentenciasPorMes(int year)
        {
            var sentenciasPorMes = new List<int>();

            for (int i = 1; i <= 12; i++)
            {
                var sentenciasMes = await _context.Sentencias
                    .Where(s => s.FechaCreacion.Month == i && s.FechaCreacion.Year == year)
                    .CountAsync();

                sentenciasPorMes.Add(sentenciasMes);
            }

            return sentenciasPorMes;
        }


        public async Task<Sentencias> ObtenerUltimaSentencia()
        {
            return await _context.Sentencias
                .OrderByDescending(d => d.FechaCreacion)
                .FirstOrDefaultAsync();
        }
    }
}
