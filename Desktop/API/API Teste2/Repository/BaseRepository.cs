using MongoDB.Driver;
using Mvc_MongoDB.Models;
using Mvc_MongoDB.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Teste2.Repository
{
    public class BaseRepository
    {
        public IMongoClient client { get; set; }
        public IMongoDatabase database { get; set; }
        public IMongoCollection<Item> collection { get; set; }
        public BaseRepository()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("ItemDB");
            collection = database.GetCollection<Item>("Itens");
        }
    }
}