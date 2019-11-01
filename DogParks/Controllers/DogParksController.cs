using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DogParks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace DogParks.Controllers
{
    public class DogParksController : ControllerBase
    {
        private DogParksContext _db;
        private readonly IHostingEnvironment hostingEnvironment;

        public DogParksController(DogParksContext db, IHostingEnvironment environment)
        {
            _db = db;
            hostingEnvironment = environment;
        }

        // GET api/dogparks
        [HttpGet]
        public ActionResult<IEnumerable<DogParks.Models.DogPark>> Get()
        {
            return _db.DogParks.ToList();
        }

        // GET api/dogparks/{id}
        // [HttpGet("{id}")]
        // public ActionResult<DogPark> Get(int id)
        // {
            
        // }

        // POST api/dogparks
        //[HttpPost]

        // PUT api/dogparks/{id}
        //[HttpPut("{id}")]

        // PATCH api/dogparks/{id}
        //[HttpPatch("{id}")]

        // DELETE api/dogparks/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}