using MongoDB.Driver;

namespace LTMongo
{
    public interface MongoCollection<T>
    {
        IMongoCollection<T> GetCollection();
        void Insert(T t);
        void Remove(T t);
    }
}