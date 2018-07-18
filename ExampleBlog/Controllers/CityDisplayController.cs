using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExampleBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ExampleBlog.Controllers
{
    public class CityDisplayController : Controller
    {
        private List<City> cities;
        public async Task<List<City>> ApiCall()
        {

            string page = "http://localhost:64991/api/Cities/";

            using (HttpClient client = new HttpClient()) //using will dispose object after use
            using (HttpResponseMessage response = await client.GetAsync(page))

            using (HttpContent content = response.Content)
            {
                // ... Read the string.
                string result = await content.ReadAsStringAsync();
                cities = JsonConvert.DeserializeObject<List<City>>(result);
            }

            return cities;
        }


        public async Task<ActionResult> Index()
        {
            List<City> returnedTaskTResult = await ApiCall();

            return View(returnedTaskTResult);
        }



    }
}