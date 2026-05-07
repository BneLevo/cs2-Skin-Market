using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    public class MongoInventoryRepository : IInventoryRepository
    {
        private readonly IMongoCollection<InventoryItem> _collection;

        public MongoInventoryRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<InventoryItem>("Inventory");
        }

        public void InsertMany(List<InventoryItem> items)
        {
            if (items.Count > 0)
            {
                _collection.InsertMany(items);
            }
        }

        public List<InventoryItem> GetByUsername(string username)
        {
            var normalized = username.Trim().ToLowerInvariant();
            return _collection.Find(i => i.Username == normalized)
                .SortByDescending(i => i.PurchasedAt)
                .ToList();
        }
    }
}
