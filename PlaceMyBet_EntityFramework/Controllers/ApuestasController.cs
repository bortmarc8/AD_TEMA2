﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet_EntityFramework.Models;

namespace PlaceMyBet_EntityFramework.Controllers
{
    public class ApuestasController : ApiController
    {
        // GET: api/Apuestas
        public List<Apuesta> Get()
        {
            ApuestasRepository repo = new ApuestasRepository();
            return repo.Retrieve();
        }

        // GET: api/Apuestas/5
        public Apuesta Get(int id)
        {
            ApuestasRepository repo = new ApuestasRepository();
            return repo.Retrieve(id);
        }

        // POST: api/Apuestas
        [Authorize]
        public void Post([FromBody]Apuesta apuesta)
        {

        }

        // PUT: api/Apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apuestas/5
        public void Delete(int id)
        {
        }
    }
}
