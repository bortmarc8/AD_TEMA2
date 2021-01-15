using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace PlaceMyBet_EntityFramework.Models
{
    public class EventosRepository
    {
        internal List<Evento> Retrieve()
        { 
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<Evento> eventos = context
                    .Eventos
                    .ToList();
                return eventos;
            }
            
        }

        internal Evento Retrieve(int id)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                Evento evento = context
                    .Eventos
                    .Where(s => s.EventoId == id)
                    .FirstOrDefault();

                return evento;
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

            context.SaveChanges();
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

        internal static EventoDTO ToDTO(Evento e)
        {
            return new EventoDTO(e.EquipoLocal, e.EquipoVisitante);
        }
    }
}