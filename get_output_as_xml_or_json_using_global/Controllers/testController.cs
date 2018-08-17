using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace get_output_as_xml_or_json_using_global.Controllers
{
    public class testController : ApiController
    {
        // GET: api/test

        // added for configure xml or json..........
        //GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
        //new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));
        //GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
        //new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));

        //api/test? type = xml
        //api/test? type = json

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/test/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/test
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/test/5
        public void Delete(int id)
        {
        }
    }
}
