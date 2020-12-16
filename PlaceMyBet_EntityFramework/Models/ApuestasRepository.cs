using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
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
                apuestas = context.Apuestas.ToList();
            }
            return apuestas;
        }

        internal Apuesta Retrieve(int id)
        {
            Apuesta apuesta;
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                apuesta = context.Apuestas
                    .Where(s => s.ApuestaId == id)
                    .FirstOrDefault();
            }
            return apuesta;
        }
    }
}