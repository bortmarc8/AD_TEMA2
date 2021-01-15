using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet_EntityFramework.Models;
using System.Web.Http.Cors;

namespace PlaceMyBet_EntityFramework.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsuariosController : ApiController
    {
        // GET: api/Users
        public List<Usuario> Get()
        {
            return new UsuariosRepository().Retrieve();
        }

        // GET: api/Users/5
        public Usuario Get(string id)
        {
            return new UsuariosRepository().Retrieve(id);

        }

        // POST: api/Users
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public void Delete(string id)
        {
            UsuariosRepository usuario = new UsuariosRepository();
            usuario.Delete(id);
        }
    }
}
