using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using PlaceMyBet_EntityFramework.Models;

namespace PlaceMyBet_EntityFramework.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EventosController : ApiController
    {
        // GET: api/Eventos
        public List<Evento> Get()
        {
            EventosRepository repo = new EventosRepository();
            return repo.Retrieve();
        }

        // GET: api/Eventos/5
        public Evento Get(int id)
        {
            EventosRepository repo = new EventosRepository();
            return repo.Retrieve(id);
        }

        // POST: api/Eventos
        public void Post([FromBody]Evento evento)
        {
            EventosRepository repo = new EventosRepository();
            repo.Save(evento);
        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody]Evento evento)
        {
            EventosRepository repo = new EventosRepository();
            repo.Update(id, evento);
        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {
            EventosRepository repo = new EventosRepository();
            repo.Remove(id);
        }
    }
}
