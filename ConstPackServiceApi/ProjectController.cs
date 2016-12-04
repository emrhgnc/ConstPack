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
    public class ProjectController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public Base Get(int id)
        {
            ProjeData pd = new ProjeData();
            Base b = pd.Projeler(id);
            return b;
            //return "value";
        }

        public Base Post([FromBody]Kullanici kullanici)
        {
            ProjeData pd = new ProjeData();
            Base b = pd.Projeler(kullanici);
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