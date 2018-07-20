using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ExampleBlog.Repo;
using ExampleBlog.Models;
namespace ExampleBlog.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class CitiesController : Controller
    {
        private MongoCityRepo cityRepo;
        public CitiesController()
        {
            cityRepo = new MongoCityRepo();
        }
        public JsonResult GetCities()
        {
            //return new JsonResult( new List<object>()
            //{
            //    new { id=1, Name="New York" },
            //    new { id=1, Name="Hyderabad" }
            //}
            //);


            //object ob1 = new { id = 1, Name = "newyork" };
            //object ob2 = new { id = 2, Name = "hyderabad" };

            //List<object> oblist = new List<object>();
            //oblist.Add(ob1);
            //oblist.Add(ob2);

            return new JsonResult(cityRepo.GetAllCitys());
        }

        [HttpGet("{id}")]
        public  JsonResult GetCityById(int id)
        {
            return new JsonResult(cityRepo.GetCityById(id));
        }

        [HttpPut("PutCity")]
        public JsonResult PutCity([FromBody] City city)
        {
            return new JsonResult(cityRepo.AddCity(city));
        }


        [HttpPost("PostCity")]
        public JsonResult PostCity(int id, string name, string description)
        {
            return new JsonResult(cityRepo.AddCity(id, name, description));
        }

    }
}