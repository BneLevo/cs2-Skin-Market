/**************************************************************************
* Nom du fichier : MongoUserRepository.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Repository MongoDB pour les utilisateurs (CRUD + budget).
**************************************************************************/

using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using MongoDB.Driver;

namespace cs2_skins_market.Data.Repositories
{
    /// <summary>
    /// Implémentation MongoDB du repository des utilisateurs.
    /// </summary>
    public class MongoUserRepository : IUserRepository
    {
        private readonly IMongoCollection<AppUser> _collection;

        /// <summary>
        /// Initialise la connexion et la collection MongoDB.
        /// </summary>
        public MongoUserRepository()
        {
            var dbClient = MongoDBconnect.Instance();
            var database = dbClient.GetDatabase("cs2_skins_market");
            _collection = database.GetCollection<AppUser>("Users");
        }

        /// <summary>
        /// Retourne l'utilisateur correspondant au username (ou null si introuvable).
        /// </summary>
        public AppUser GetByUsername(string username)
        {
            var normalized = Normalize(username);
            return _collection.Find(u => u.Username == normalized).FirstOrDefault();
        }

        /// <summary>
        /// Indique si un utilisateur existe déjà.
        /// </summary>
        public bool UsernameExists(string username)
        {
            var normalized = Normalize(username);
            return _collection.Find(u => u.Username == normalized).Any();
        }

        /// <summary>
        /// Insère un nouvel utilisateur.
        /// </summary>
        public void Insert(AppUser user)
        {
            user.Username = Normalize(user.Username);
            _collection.InsertOne(user);
        }

        /// <summary>
        /// Met à jour le budget exact de l'utilisateur.
        /// </summary>
        public void UpdateBudget(string username, double newBudget)
        {
            var normalized = Normalize(username);
            var filter = Builders<AppUser>.Filter.Eq(u => u.Username, normalized);
            var update = Builders<AppUser>.Update.Set(u => u.Budget, newBudget);
            _collection.UpdateOne(filter, update);
        }

        /// <summary>
        /// Incrémente le budget de l'utilisateur.
        /// </summary>
        public void IncrementBudget(string username, double delta)
        {
            var normalized = Normalize(username);
            var filter = Builders<AppUser>.Filter.Eq(u => u.Username, normalized);
            var update = Builders<AppUser>.Update.Inc(u => u.Budget, delta);
            _collection.UpdateOne(filter, update);
        }

        /// <summary>
        /// Normalise un username.
        /// </summary>
        private static string Normalize(string username) => username.Trim().ToLowerInvariant();
    }
}
