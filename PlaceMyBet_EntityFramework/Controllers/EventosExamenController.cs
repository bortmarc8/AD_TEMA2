using PlaceMyBet_EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace PlaceMyBet_EntityFramework.Controllers
{
    public class EventosExamenController : ApiController
    {
        public void Get()
        {

        }

        // GET: api/Eventos/5
        public List<EventoDTOExamen> Get(string val)
        {
            EventosRepository repo = new EventosRepository();
            return repo.Retrieve(val);
        }

        // POST: api/Eventos
        public void Post([FromBody] Evento evento)
        {

        }

        // PUT: api/Eventos/5
        public void Put(int id, [FromBody] Evento evento)
        {

        }

        // DELETE: api/Eventos/5
        public void Delete(int id)
        {

        }
    }
}
