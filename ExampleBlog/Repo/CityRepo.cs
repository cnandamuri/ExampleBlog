using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleBlog.Models;
namespace ExampleBlog.Repo
{
    public class CityRepo
    {
        public CityRepo()
        {
            Populate();
        }
        public List<City> Cities = new List<City>();
        public void Populate()
        {
            City ob1 = new City() { Id = 1, Name = "New York", Description="One of larger city's in world " };
            City ob2 = new City() { Id = 2, Name = "Hyderabad", Description = "One of larger city's in India" };
            Cities.Add(ob1);
            Cities.Add(ob2);
        }

        public List<City> GetAllCitys()
        {
            return Cities;
        }


        public City GetCityById(int id)
        {
            return Cities.SingleOrDefault(X => X.Id == id);
            //return Cities.FirstOrDefault(x => x.id == id);
        }

        public List<City> AddCity(City city)
        {
            Cities.Add(city);
            return Cities;
        }


        public List<City> AddCity(int id, string name, string description)
        {
            Cities.Add(new City() { Id = id, Name = name, Description = description });
            return Cities;
        }
    }
}
