using MongoDB.Driver;

namespace CdpDotnetBackendTemplate.Utils.Mongo;

public interface IMongoDbClientFactory
{
    IMongoClient GetClient();

    IMongoCollection<T> GetCollection<T>(string collection);
}