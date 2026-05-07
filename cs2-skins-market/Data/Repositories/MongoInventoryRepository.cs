/**************************************************************************
* Nom du fichier : MongoInventoryRepository.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Repository MongoDB pour l'inventaire utilisateur.
**************************************************************************/

using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    /// <summary>
    /// Implémentation MongoDB du repository d'inventaire.
    /// </summary>
    public class MongoInventoryRepository : IInventoryRepository
    {
        private readonly IMongoCollection<InventoryItem> _collection;

        /// <summary>
        /// Initialise la connexion et la collection MongoDB.
        /// </summary>
        public MongoInventoryRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<InventoryItem>("Inventory");
        }

        /// <summary>
        /// Insère plusieurs éléments d'inventaire.
        /// </summary>
        public void InsertMany(List<InventoryItem> items)
        {
            if (items.Count > 0)
            {
                _collection.InsertMany(items);
            }
        }

        /// <summary>
        /// Retourne l'inventaire d'un utilisateur trié par date décroissante.
        /// </summary>
        public List<InventoryItem> GetByUsername(string username)
        {
            var normalized = username.Trim().ToLowerInvariant();
            return _collection.Find(i => i.Username == normalized)
                .SortByDescending(i => i.PurchasedAt)
                .ToList();
        }
    }
}
