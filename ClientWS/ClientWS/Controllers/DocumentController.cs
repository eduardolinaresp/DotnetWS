using ClientWS.Models;
using ClientWS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientWS.Controllers
{
    public class DocumentController : ApiController
    {
       private DocumentService service = new DocumentService();
        // GET: api/Document
        public IEnumerable<string> Get()
        {
          bool blogica =  service.call_web_service();

          return new string[] { "respuesta", "", blogica ? "OK" : "ERROR", ""};
        }

        private string Base64Encode(string v)
        {
            throw new NotImplementedException();
        }

        // GET: api/Document/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Document
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Document/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Document/5
        public void Delete(int id)
        {
        }
    }
}
