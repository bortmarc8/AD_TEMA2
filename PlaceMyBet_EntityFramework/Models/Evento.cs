using System;
using System.Collections.Generic;

namespace PlaceMyBet_EntityFramework.Models
{
    public class Evento
    {
        public Evento()
        {

        }

        public Evento(int eventoId, string equipoLocal, string equipoVisitante, DateTime fecha)
        {
            EventoId = eventoId;
            eq_local = equipoLocal;
            eq_visitante = equipoVisitante;
            Fecha = fecha;
        }

        public int EventoId { get; set; }
        public string eq_local { get; set; }
        public string eq_visitante { get; set; }
        public int Goles { get; set; }
        public DateTime Fecha { get; set; }
        public Mercado info_mercado { get; set; }

    }

    public class EventoDTO
    {
        public EventoDTO(string equipoLocal, string equipoVisitante)
        {
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
        }

        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
    }

    public class EventoDTOExamen
    {
        public EventoDTOExamen(string equipoRival, List<MercadoDTOExamen> mercados)
        {
            EquipoRival = equipoRival;
            Mercados = mercados;
        }

        public string EquipoRival { get; set; }
        public List<MercadoDTOExamen> Mercados { get; set; }
    }
}