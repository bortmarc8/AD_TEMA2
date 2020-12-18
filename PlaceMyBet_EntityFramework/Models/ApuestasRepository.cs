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
                    mercado.dinero_over += apuesta.Dinero;
                else
                    mercado.dinero_under     += apuesta.Dinero;

                if (apuesta.Fecha.ToString() == "01/01/0001 0:00:00")
                    apuesta.Fecha = DateTime.Now;

                mercado.cuota_over = 1 / (mercado.dinero_over / (mercado.dinero_over + mercado.dinero_under)) * 0.95;
                mercado.cuota_under = 1 / (mercado.dinero_under / (mercado.dinero_under + mercado.dinero_under)) * 0.95;

                if (apuesta.TipoApuesta)
                    apuesta.Cuota = mercado.cuota_over;
                else
                    apuesta.Cuota = mercado.cuota_over;

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