using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace LTMongo
{
    public class MongoClient : IMongoClient
    {
        private IMongoDatabase _database { get; set; }

        public MongoClient(IOptions<MongoSettings> mongoSettings)
        {
            var client = new MongoDB.Driver.MongoClient(mongoSettings.Value.ConnectionString);
            if(client != null)
            {
                _database = client.GetDatabase(mongoSettings.Value.Database);
            }
        }

        IMongoDatabase IMongoClient.GetDatabase()
        {
            return _database;
        }
    }
}