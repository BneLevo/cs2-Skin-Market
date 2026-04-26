using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    class MongoSkinRepository : ISkinRepository
    {
        private readonly IMongoCollection<Skin> _collection;

        public MongoSkinRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<Skin>("Skins");
        }

        public List<Skin> GetAllSkins()
        {
            return _collection.Find(skin => true).ToList();
        }

        public void SeedData(List<Skin> skins)
        {
            _collection.InsertMany(skins);
        }

        public void InsertMany(List<Skin> skins)
        {
            if (skins != null && skins.Count > 0)
            {
                _collection.InsertMany(skins);
            }
        }

        public long GetCount() => _collection.CountDocuments(FilterDefinition<Skin>.Empty);
    }
}
