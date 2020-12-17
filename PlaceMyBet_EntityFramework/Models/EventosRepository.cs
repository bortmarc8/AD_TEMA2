using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;

namespace PlaceMyBet_EntityFramework.Models
{
    public class EventosRepository
    {
        internal List<EventoDTO> Retrieve()
        { 
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<EventoDTO> eventos = context
                    .Eventos
                    .Select(p => ToDTO(p))
                    .ToList();
                return eventos;
            }
            
        }

        internal void Save(Evento evento)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            context.Eventos.Add(evento);
            context.SaveChanges();
        }

        internal void Update(int id, Evento e)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Eventos
                    .Where(s => s.EventoId == id)
                    .FirstOrDefault();

            evento.EquipoLocal = e.EquipoLocal;
            evento.EquipoVisitante = e.EquipoVisitante;
            evento.Goles = e.Goles;
            evento.Fecha = e.Fecha;

            Save(evento);
        }

        internal void Remove(int id)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();
            Evento evento = context.Eventos
                    .Where(s => s.EventoId == id)
                    .FirstOrDefault();

            context.Remove(evento);
            context.SaveChanges();

        }

        internal EventoDTO ToDTO(Evento e)
        {
            return new EventoDTO(e.EquipoLocal, e.EquipoVisitante);
        }
    }
}