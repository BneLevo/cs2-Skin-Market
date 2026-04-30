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

        public List<Skin> GetSkinsByName(string name)
        {
            // 1. On divise la recherche en mots-clés (ex: "Red" et "Butterfly")
            // 'RemoveEmptyEntries' évite les erreurs s'il y a plusieurs espaces
            var words = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var builder = Builders<Skin>.Filter;

            // Liste pour stocker les filtres individuels de chaque mot
            var filterList = new List<FilterDefinition<Skin>>();

            // 2. Création d'un filtre Regex pour chaque mot-clé
            foreach (var word in words)
            {
                // "i" signifie case-insensitive (ignore la casse Majuscule/Minuscule)
                filterList.Add(builder.Regex(s => s.Name, new MongoDB.Bson.BsonRegularExpression(word, "i")));
            }

            // 3. On combine tous les filtres avec l'opérateur "AND"
            // Le skin doit contenir TOUS les mots-clés pour être affiché
            var combinedFilter = builder.And(filterList);

            // 4. Exécution de la requête sur la collection MongoDB
            return _collection.Find(combinedFilter).ToList();
        }

        public List<Skin> GetSkinsByMinPrice(double min)
        {
            var filter = Builders<Skin>.Filter.Gte(s => s.Price, min);
            return _collection.Find(filter).ToList();
        }

        public List<Skin> GetSkinsByMaxPrice(double max)
        {
            var filter = Builders<Skin>.Filter.Lte(s => s.Price, max);
            return _collection.Find(filter).ToList();
        }

        public List<Skin> GetSkinsByPriceRange(double min, double max)
        {
            var filter = Builders<Skin>.Filter.Gte(s => s.Price, min) & Builders<Skin>.Filter.Lte(s => s.Price, max);
            return _collection.Find(filter).ToList();
        }
    }
}
