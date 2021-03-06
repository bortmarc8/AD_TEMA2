﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet_EntityFramework.Models;

namespace PlaceMyBet_EntityFramework.Controllers
{
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public List<Evento> Get()
        {
            EventosRepository repo = new EventosRepository();
            return repo.Retrieve();
        }

        // GET: api/Eventos/5
        public void Get(int id)
        {

        }

        // POST: api/Eventos
        public void Post([FromBody]Evento evento)
        {
            EventosRepository repo = new EventosRepository();
            repo.Save(evento);
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
        }
    }
}
