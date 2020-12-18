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
            this.tipo = tipo;
            cuota_over = cuotaOver;
            cuota_under = cuotaUnder;
            dinero_over = dineroOver;
            dinero_under = dineroUnder;
            EventoId = eventoId;
        }

        public Mercado(double tipo, double cuotaOver, double cuotaUnder, double dineroOver, double dineroUnder, int eventoId)
        {
            this.tipo = tipo;
            cuota_over = cuotaOver;
            cuota_under = cuotaUnder;
            dinero_over = dineroOver;
            dinero_under = dineroUnder;
            EventoId = eventoId;
        }

        public int MercadoId { get; set; }
        public double tipo { get; set; }
        public double cuota_over { get; set; }
        public double cuota_under { get; set; }
        public double dinero_over { get; set; }
        public double dinero_under { get; set; }
        public Evento Evento { get; set; }
        public int EventoId { get; set; }

    }

    public class MercadoDTO
    {
        public MercadoDTO(double tipo, double cuotaOver, double cuotaUnder)
        {
            Tipo = tipo;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
        }

        public double Tipo { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }

    }

    public class MercadoDTOExamen
    {   
        public MercadoDTOExamen(int mercadoId, double cuotaOver, double cuotaUnder)
        {
            MercadoId = mercadoId;
            CuotaOver = cuotaOver;
            CuotaUnder = cuotaUnder;
        }

        public double MercadoId { get; set; }
        public double CuotaOver { get; set; }
        public double CuotaUnder { get; set; }

    }
}