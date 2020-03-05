
using API_Teste2.Repository;
using API_Teste2.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using Mvc_MongoDB.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;

namespace Mvc_MongoDB.Repository
{
    public class ItemDB : BaseRepository
    {
        public MongoDatabase Database;
        public String DataBaseName = "ItemDB";

        public MongoCollection<Item> Itens
        {

            get
            {
                var Itens = Database.GetCollection<Item>("Itens");
                return Itens;
            }
        }
        public void Create (Item item)
        {             
            collection.InsertOne(item);
        }
        public void Edit(Item item)
        {
            var builder = Builders<Item>.Filter;
            var filter = builder.Eq(x => x.Id, item.Id);
            collection.FindOneAndDelete(filter);
            collection.InsertOne(item);
            

        }
        public List<Item> Get()
        {
            var res = collection.Find(Builders<Item>.Filter.Empty).ToList();
            return res;
        }
        public void Delete(Item item)
        {
            var builder = Builders<Item>.Filter;
            var filter = builder.Eq(x => x.Id, item.Id);
            collection.FindOneAndDelete(filter);
        }
    }
}