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
        public ActionResult<IEnumerable<DogParks.Models.DogPark>> Get(string name, string area, string address, string hours)
        {
            var query = _db.DogParks.AsQueryable();

            if(name != null)
            {
                query = query.Where(entry => entry.Name.ToLower().Contains(name.ToLower()));
            }
            if (area != null)
            {
                query = query.Where(entry => entry.Area.ToLower().Contains(area.ToLower()));
            }
            if (address != null)
            {
                query = query.Where(entry => entry.Address.ToLower().Contains(address.ToLower()));
            }
            if (hours != null)
            {
                query = query.Where(entry => entry.Hours.ToLower().Contains(hours.ToLower()));
            }
            return _db.DogParks.ToList();
        }

        // GET api/dogparks/{id}
        [HttpGet("{id}")]
        public ActionResult<DogParks.Models.DogPark> Get(int id)
        {
            return _db.DogParks.FirstOrDefault(entry => entry.DogParkId == id);
        }

        // POST api/dogparks
        [HttpPost]
        public void Post([FromBody] DogParks.Models.DogPark dogPark)
        {
            _db.DogParks.Add(dogPark);
            _db.SaveChanges();
        }

        // PUT api/dogparks/{id}
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DogParks.Models.DogPark dogPark)
        {
            dogPark.DogParkId = id;
            _db.Entry(dogPark).State = EntityState.Modified;
            _db.SaveChanges();
        }
        
        // PATCH api/dogparks/{id}
        [HttpPatch("{id}")]
        public void Update(int id, [FromBody] string name, string hours, string photoPath)
        {
            DogParks.Models.DogPark dp = _db.DogParks.FirstOrDefault(entry => entry.DogParkId == id);
            if (name != null)
            {
                dp.Name = name;
            }
            if (hours != null)
            {
                dp.Hours = hours;
            }
            if (photoPath != null)
            {
                dp.PhotoPath = photoPath;
            }
            _db.Entry(dp).State = EntityState.Modified;
            _db.SaveChanges();
        }


        // DELETE api/dogparks/{id}
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var deleteMe = _db.DogParks.FirstOrDefault(entry => entry.DogParkId == id);
            _db.DogParks.Remove(deleteMe);
            _db.SaveChanges();

        }
    }
}