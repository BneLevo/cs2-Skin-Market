/**************************************************************************
* Nom du fichier : AppUser.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Modèle représentant un utilisateur enregistré (compte + budget).
**************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    /// <summary>
    /// Représente un utilisateur enregistré dans la base de données.
    /// </summary>
    public class AppUser
    {
        private string _id = "";
        private string _username = "";
        private string _passwordHash = "";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        /// <summary>
        /// Identifiant MongoDB (ObjectId).
        /// </summary>
        public string Id
        {
            get => _id;
            set => _id = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("username")]
        /// <summary>
        /// Nom d'utilisateur (normalisé).
        /// </summary>
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("passwordHash")]
        /// <summary>
        /// Hash SHA256 du mot de passe.
        /// </summary>
        public string PasswordHash
        {
            get => _passwordHash;
            set => _passwordHash = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("budget")]
        /// <summary>
        /// Budget disponible pour l'utilisateur.
        /// </summary>
        public double Budget { get; set; }
    }
}
