using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Web.WebPages;

namespace PlaceMyBet_EntityFramework.Models
{
    public class ApuestasRepository
    {
        internal List<ApuestaDTO> Retrieve()
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<ApuestaDTO> apuestas = context
                    .Apuestas
                    .Select(p => ToDTO(p))
                    .ToList();
                return apuestas;

            }

        }

        internal Apuesta Retrieve(int id)
        {
            Apuesta apuesta;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuestas
                    .Include(p => p.Mercado)
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

                if (apuesta.Fecha.ToString() == "01/01/0001 0:00:00")
                    apuesta.Fecha = DateTime.Now;

                mercado.CuotaOver = 1 / (mercado.DineroOver / (mercado.DineroOver + mercado.DineroUnder)) * 0.95;
                mercado.CuotaUnder = 1 / (mercado.DineroUnder / (mercado.DineroOver + mercado.DineroUnder)) * 0.95;

                if (apuesta.TipoApuesta)
                    apuesta.Cuota = mercado.CuotaOver;
                else
                    apuesta.Cuota = mercado.CuotaUnder;

                context.Apuestas.Add(apuesta); ;

                context.SaveChanges();


            }
        }

        internal static ApuestaDTO ToDTO(Apuesta e)
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