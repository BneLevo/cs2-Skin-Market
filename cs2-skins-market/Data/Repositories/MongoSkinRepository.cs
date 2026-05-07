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

        public List<Skin> GetSkinsByFilter(string name, double min, double max)
        {
            var builder = Builders<Skin>.Filter;
            var filters = new List<FilterDefinition<Skin>>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                var words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    filters.Add(builder.Regex(s => s.Name, new MongoDB.Bson.BsonRegularExpression(word, "i")));
                }
            }

            if (min > 0)
            {
                filters.Add(builder.Gte(s => s.Price, min));
            }

            if (max < double.MaxValue)
            {
                filters.Add(builder.Lte(s => s.Price, max));
            }

            if (filters.Count == 0)
            {
                return _collection.Find(builder.Empty).ToList();
            }

            var combinedFilter = builder.And(filters);
            return _collection.Find(combinedFilter).ToList();
        }
    }
}
