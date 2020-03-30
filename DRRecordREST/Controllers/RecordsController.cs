using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DRRecordREST.Models;

namespace DRRecordREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordsController : ControllerBase
    {
        private static readonly List<Record> records = new List<Record>()
        {
            new Record("Coopers Rum", "Ye Banished Privateers", 3.22, 2017),
            new Record("Castle of Glass", "Linkin Park", 3.44, 2011)
        };

        // GET: api/Records
        [HttpGet]
        public IEnumerable<Record> GetRecords()
        {
            return records;
        }

        // GET: api/Records/5
        [HttpGet]
        [Route("{title}")]
        public Record GetByTitle(string title)
        {
            return records.Find(i => i.Title == title);
        }

        [HttpGet]
        [Route("{author}")]
        public Record GetByArtist(string artist)
        {
            return records.Find(i => i.Artist == artist);
        }

        // POST: api/Records
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Records/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
