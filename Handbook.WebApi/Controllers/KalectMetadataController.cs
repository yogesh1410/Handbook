using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Handbook.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/KalectMetadata")]
    public class KalectMetadataController : Controller
    {
        // GET: api/KalectMetadata
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            //Read JSON Files
            string assessment1 = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment1.json");
            string assessment2 = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment2.json");
            string assessment3 = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment3.json");

            List<string> assessments = new List<string>();
            assessments.Add(assessment1);
            assessments.Add(assessment2);
            assessments.Add(assessment3);

            return assessments;
        }

        // GET: api/KalectMetadata/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            string assessment = string.Empty;
            if (id == 1)
            {
                assessment = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment1.json");
            }
            else if(id == 2)
            {
                assessment = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment2.json");
            }
            else if(id == 3)
            {
                assessment = System.IO.File.ReadAllText("./MockMetadata/KalectMetadataAssessment3.json");
            }

            return assessment;
        }

        // POST: api/KalectMetadata
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/KalectMetadata/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
