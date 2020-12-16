using System;
using System.Collections.Generic;

namespace PlaceMyBet_EntityFramework.Models
{
    public class Mercado
    {
        public Mercado()
        { 
        
        }

        public Mercado(int mercadoId, double tipo, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, int eventoId)
        {
            MercadoId = mercadoId;
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
            DineroOver = dineroOver;
            DineroUnder = dineroUnder;
            EventoId = eventoId;
        }

        public int MercadoId { get; set; }
        public double Tipo { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }
        public double DineroOver { get; set; }
        public double DineroUnder { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }

    }

}