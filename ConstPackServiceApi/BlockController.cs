using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityLayer;
using DataLayer;

namespace ConstPackServiceApi
{
    public class BlockController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Base Get(int id)
        {
            BlokData bd = new BlokData();
            Base b = bd.Bloklar(id);
            return b;
        }

        // POST api/<controller>
        public Base Post([FromBody]Proje proje)
        {
            BlokData bd = new BlokData();
            Base b = bd.Bloklar(proje);
            return b;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}