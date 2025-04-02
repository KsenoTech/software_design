using DAL.DbContexts;
using DomainModel;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Type = DomainModel.Type;

namespace DAL
{

    public class MongoContext
    {
        string connectionString;
        //MongoClient client;
        IMongoDatabase database;

        /// <summary>
        ///  коллекция Motos
        /// </summary>
        public IMongoCollection<Motorcycle> MotoCollection
        {
            get { return database.GetCollection<Motorcycle>("Motorcycle"); }
        }
        /// <summary>
        ///  коллекция Order
        /// </summary>
        public IMongoCollection<Order> OrderCollection
        {
            get { return database.GetCollection<Order>("Order"); }
        }
        public IMongoCollection<Type> TypeCollection
        {
            get { return database.GetCollection<Type>("Type"); }
        }

        public MongoContext(string cs)
        {
            connectionString = cs;
            var connection = new MongoUrlBuilder(connectionString);
            MongoClient client = new MongoClient(connectionString);
            database = client.GetDatabase(connection.DatabaseName);

           // Заполнение справочника из кода приложения:
            if (TypeCollection.CountDocuments(FilterDefinition<Type>.Empty) == 0) Seed();
        }

        private void Seed()
        {
            TypeCollection.InsertMany(InitialData.TypeList);
        }
    }
}

