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
            EquipoLocal = equipoLocal;
            EquipoVisitante = equipoVisitante;
            Fecha = fecha;
        }

        public int EventoId { get; set; }
        public string EquipoLocal { get; set; }
        public string EquipoVisitante { get; set; }
        public int Goles { get; set; }
        public DateTime Fecha { get; set; }
        public List<Mercado> Mercados { get; set; }

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
}