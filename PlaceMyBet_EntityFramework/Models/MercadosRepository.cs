using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;

namespace PlaceMyBet_EntityFramework.Models
{
    public class MercadosRepository
    {
        internal List<MercadoDTO> Retrieve()
        { 
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<MercadoDTO> mercados = context
                    .Mercados
                    .Select(p => ToDTO(p))
                    .ToList();

                return mercados;
            }
            
        }

        internal Mercado Retrieve(int id)
        {
            Mercado mercado;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                mercado = context.Mercados
                    .Include(p => p.Evento)
                    .Where(s => s.MercadoId == id)
                    .FirstOrDefault();
            }
            return mercado;
        }

        internal void Save(Mercado mercado)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Mercados.Add(mercado);
            context.SaveChanges();
        }

        internal static MercadoDTO ToDTO(Mercado e)
        {
            return new MercadoDTO(e.tipo, e.dinero_over, e.cuota_under);
        }
    }
}