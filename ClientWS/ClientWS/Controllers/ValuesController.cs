using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientWS.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            //WebService1SoapClient ws = new WebService1SoapClient();
            string mensaje;
            try
            {
                //ws.Open();
                //mensaje = ws.HelloWorld("Hola desde Cliente");

                mensaje = "";

                //ws.Close();
            }
            catch (Exception)
            {

                throw;
            }


            return new string[] { "Mensaje", mensaje };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
