/**************************************************************************
* Nom du fichier : MongoSkinRepository.cs
* Auteur : Ozgun Levent
* Date de création : 30.04.2026
* Description : Repository MongoDB pour les skins (lecture/filtrage).
**************************************************************************/

using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    /// <summary>
    /// Implémentation MongoDB du repository des skins.
    /// </summary>
    class MongoSkinRepository : ISkinRepository
    {
        private readonly IMongoCollection<Skin> _collection;

        /// <summary>
        /// Initialise la connexion et la collection MongoDB.
        /// </summary>
        public MongoSkinRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<Skin>("Skins");
        }

        /// <summary>
        /// Retourne tous les skins.
        /// </summary>
        public List<Skin> GetAllSkins()
        {
            return _collection.Find(skin => true).ToList();
        }

        /// <summary>
        /// Insert (legacy) utilisé lors du seed.
        /// </summary>
        public void SeedData(List<Skin> skins)
        {
            _collection.InsertMany(skins);
        }

        /// <summary>
        /// Insère plusieurs skins.
        /// </summary>
        public void InsertMany(List<Skin> skins)
        {
            if (skins != null && skins.Count > 0)
            {
                _collection.InsertMany(skins);
            }
        }

        /// <summary>
        /// Retourne le nombre total de skins en base.
        /// </summary>
        public long GetCount() => _collection.CountDocuments(FilterDefinition<Skin>.Empty);

        /// <summary>
        /// Filtre les skins par nom et plage de prix.
        /// </summary>
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
