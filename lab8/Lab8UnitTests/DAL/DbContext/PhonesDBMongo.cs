using DAL.DbContexts;
using DomainModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL
{

    public class MongoContext
    {
        string connectionString;
        MongoClient client;
        IMongoDatabase database;

        /// <summary>
        ///  коллекция Phones
        /// </summary>
        public IMongoCollection<Phone> PhoneCollection
        {
            get { return database.GetCollection<Phone>("Phone"); }
        }
        /// <summary>
        ///  коллекция Order
        /// </summary>
        public IMongoCollection<Order> OrderCollection
        {
            get { return database.GetCollection<Order>("Order"); }
        }
        public IMongoCollection<Manufacturer>  ManufacturerCollection
        {
            get { return database.GetCollection<Manufacturer>("Manufacturer"); }
        }
       
        public MongoContext(string cs)
        {
            connectionString = cs;
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase(connection.DatabaseName);

            if (ManufacturerCollection.CountDocuments(FilterDefinition<Manufacturer>.Empty) == 0) Seed();
        }

        private void Seed()
        {
            ManufacturerCollection.InsertMany(InitialData.ManufacturerList);
        }


    }
}

