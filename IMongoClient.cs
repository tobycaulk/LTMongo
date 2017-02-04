using MongoDB.Driver;

namespace LTMongo
{
    public interface IMongoClient
    {
        IMongoDatabase GetDatabase();
    }
}