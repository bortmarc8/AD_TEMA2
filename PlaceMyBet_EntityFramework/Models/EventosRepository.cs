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
        internal void Retrieve()
        { 
            
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

        internal List<EventoDTOExamen> Retrieve(string val)
        {
            using (PlaceMyBetContext context = new PlaceMyBetContext())
            {
                List<Evento> eventoLocal = context
                    .Eventos
                    .Where(s => s.EquipoLocal == val)
                    .Include(p => p.Mercados)
                    .ToList();

                List<Evento> eventoVisitante = context
                    .Eventos
                    .Where(s => s.EquipoVisitante == val)
                    .Include(p => p.Mercados)
                    .ToList();

                foreach (var item in eventoVisitante)
                {
                    item.EquipoVisitante = item.EquipoLocal;
                    eventoLocal.Add(item);
                }

                List<EventoDTOExamen> eventoFinal = new List<EventoDTOExamen>();
                foreach (var item in eventoLocal)
                {
                    eventoFinal.Add(new EventoDTOExamen(item.EquipoVisitante, ToDTO(item.Mercados)));
                }

                return eventoFinal;
            }

        }

        internal void Save(Evento evento)
        {
            PlaceMyBetContext context = new PlaceMyBetContext();

            if (evento.Fecha.ToString() == "01/01/0001 0:00:00")
                evento.Fecha = DateTime.Now;

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

        internal static EventoDTOExamen ToDTO(Evento e)
        {
            return new EventoDTOExamen(e.EquipoLocal, ToDTO(e.Mercados));
        }

        internal static List<MercadoDTOExamen> ToDTO(List<Mercado> e)
        {
            List<MercadoDTOExamen> lista = new List<MercadoDTOExamen>();

            foreach (var item in e)
            {
                lista.Add(new MercadoDTOExamen(item.MercadoId, item.CuotaOver, item.CuotaUnder));
            }
            return lista;
        }
    }
}