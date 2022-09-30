using ClimaTempoSimples.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;

namespace ClimaTempoSimples.Models
{
    public static class ProcessarPrevisao
    {
        public static List<Models.PrevisaoClima> CidadesMaisFrias(ClimaDbContext _context)
        {
            DateTime data = DateTime.Now;
            int numCidades = 3;

            return _context.PrevisaoClima
                .Where(d => d.DataPrevisao == data)
                .OrderBy(t => t.TemperaturaMinima).ThenBy(t => t.TemperaturaMaxima)
                .Include(e => e.Cidade.Estado)
                .Take(numCidades)
                .ToList();

        }

        public static List<Models.PrevisaoClima> CidadesMaisQuentes(ClimaDbContext _context)
        {
            DateTime data = DateTime.Now;
            
            int numCidades = 3;

            return _context.PrevisaoClima
                .Where(d => d.DataPrevisao == data)
                .OrderByDescending(t => t.TemperaturaMaxima).ThenByDescending(t => t.TemperaturaMinima)
                .Include(e => e.Cidade.Estado)
                .Take(numCidades)
                .ToList();

        }

        public static List<Models.PrevisaoClima> ProximosDias(ClimaDbContext _context, int cidade)
        {
            DateTime data = DateTime.Now;
            
            int numDias = 7;

            var previsao = _context.PrevisaoClima
                .Where(d => d.DataPrevisao >= data && d.CidadeId==cidade)
                .OrderBy(d => d.DataPrevisao)
                .Include(e => e.Cidade.Estado)
                .Take(numDias)
                .ToList();

            foreach(var item in previsao)
                item.DiaSemama = item.DataPrevisao.ToString("dddd", new CultureInfo("pt-BR"));
            

            return previsao;
        }
    }
}