using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PlaceMyBet_EntityFramework.Models
{
    public class ApuestasRepository
    {
        internal List<Apuesta> Retrieve()
        { 
            List<Apuesta> apuestas = new List<Apuesta>();
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuestas = context.Apuestas
                    .Include(p => p.Mercado)
                    .Include(p => p.Usuario)
                    .ToList();
            }
            return apuestas;
        }

        internal Apuesta Retrieve(int id)
        {
            Apuesta apuesta;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuestas
                    .Include(p => p.Mercado)
                    .Include(p => p.Usuario)
                    .Where(s => s.ApuestaId == id)
                    .FirstOrDefault();
            }
            return apuesta;
        }

        internal void Save(Apuesta apuesta)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Mercado mercado;

                mercado = context.Mercados
                    .Where(s => s.MercadoId == apuesta.MercadoId)
                    .FirstOrDefault();

                if (apuesta.TipoApuesta)
                    mercado.DineroOver += apuesta.Dinero;
                else
                    mercado.DineroUnder += apuesta.Dinero;

                mercado.CuotaOver = 1 / (mercado.DineroOver / (mercado.DineroOver + mercado.DineroUnder)) * 0.95;
                mercado.CuotaUnder = 1 / (mercado.DineroUnder / (mercado.DineroOver + mercado.DineroUnder)) * 0.95;

                context.SaveChanges();
            }
        }

        public ApuestaDTO ToDTO(Apuesta e)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Apuesta apuesta = context.Apuestas
                    .Include(p => p.Mercado)
                    .Where(s => s.ApuestaId == e.ApuestaId)
                    .FirstOrDefault();

                Mercado mercado = context.Mercados
                    .Where(s => s.MercadoId == apuesta.MercadoId)
                    .FirstOrDefault();

                return new ApuestaDTO(e.UsuarioId, mercado.EventoId, e.TipoApuesta, e.Cuota, e.Dinero);
            }
        }
    }
}