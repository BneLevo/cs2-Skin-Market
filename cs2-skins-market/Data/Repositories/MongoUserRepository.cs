using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    public class MongoUserRepository : IUserRepository
    {
        private readonly IMongoCollection<AppUser> _collection;

        public MongoUserRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<AppUser>("Users");
        }

        public AppUser GetByUsername(string username)
        {
            var normalized = Normalize(username);
            return _collection.Find(u => u.Username == normalized).FirstOrDefault();
        }

        public bool UsernameExists(string username)
        {
            var normalized = Normalize(username);
            return _collection.Find(u => u.Username == normalized).Any();
        }

        public void Insert(AppUser user)
        {
            user.Username = Normalize(user.Username);
            _collection.InsertOne(user);
        }

        public void UpdateBudget(string username, double newBudget)
        {
            var normalized = Normalize(username);
            var filter = Builders<AppUser>.Filter.Eq(u => u.Username, normalized);
            var update = Builders<AppUser>.Update.Set(u => u.Budget, newBudget);
            _collection.UpdateOne(filter, update);
        }

        public void IncrementBudget(string username, double delta)
        {
            var normalized = Normalize(username);
            var filter = Builders<AppUser>.Filter.Eq(u => u.Username, normalized);
            var update = Builders<AppUser>.Update.Inc(u => u.Budget, delta);
            _collection.UpdateOne(filter, update);
        }

        private static string Normalize(string username) => username.Trim().ToLowerInvariant();
    }
}
