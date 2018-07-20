using ExampleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace ExampleBlog.Repo
{
    public class MongoCityRepo
    {
        private IMongoCollection<City> collection;
        public MongoCityRepo()
        {
            string connectionString = "mongodb://Chaitanya:8d99N^doVDFl@ds243501.mlab.com:43501/exampleblog";
                                                    
            MongoUrl url = MongoUrl.Create(connectionString);
            MongoClient mongoClient = new MongoClient(url);
            IMongoDatabase database = mongoClient.GetDatabase(url.DatabaseName);
            collection = database.GetCollection<City>("Cities");
        }
        public List<City> GetAllCitys()
        {
            //return collection.AsQueryable<City>().Select(x=> x).ToList<City>();
            return collection.AsQueryable().Where<City>(x => x.Id > 0).ToList<City>();
        }


        public City GetCityById(int id)
        {
            return collection.AsQueryable().FirstOrDefault<City>(x => x.Id == id);
        }

        public bool AddCity(City city) 
        {
            //FilterDefinition<City> filter1 = Builders<City>.Filter.Where(x => x.Id == city.Id);
            //ReplaceOneResult replaceOneResult = collection.ReplaceOne(filter, city, new UpdateOptions { IsUpsert = true });
            ReplaceOneResult replaceOneResult = collection.ReplaceOne(x => x.Id == city.Id, city);
            return replaceOneResult.IsAcknowledged;
        }


        public IMongoCollection<City> AddCity(int id, string name, string description)
        {
            //Cities.Add(new City() { Id = id, Name = name, Description = description });
            //return Cities;
            return collection;
        }
    }
}
