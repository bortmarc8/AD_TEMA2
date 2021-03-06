﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PlaceMyBet_EntityFramework.Models;

namespace PlaceMyBet_EntityFramework.Controllers
{
    public class MercadosController : ApiController
    {
        // GET: api/Mercsdos
        public List<Mercado> Get()
        {
            return new MercadosRepository().Retrieve();
        }


        // GET: api/Mercsdos/5
        public Mercado Get(int id)
        {
            return new MercadosRepository().Retrieve(id);
        }

        // POST: api/Mercsdos
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Mercsdos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Mercsdos/5
        public void Delete(int id)
        {
        }
    }
}
