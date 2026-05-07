/**************************************************************************
* Nom du fichier : UserInventoryItem.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Modèle représentant un élément de l'inventaire d'un utilisateur.
**************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    /// <summary>
    /// Représente un skin possédé par un utilisateur (historique + prix d'achat).
    /// </summary>
    public class InventoryItem
    {
        private string _id = "";
        private string _username = "";
        private string _skinId = "";
        private string _name = "";

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
        /// Username du propriétaire.
        /// </summary>
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("skinId")]
        /// <summary>
        /// Id du skin dans la collection marketplace.
        /// </summary>
        public string SkinId
        {
            get => _skinId;
            set => _skinId = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("name")]
        /// <summary>
        /// Nom affiché dans l'inventaire (souvent inclut la date).
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("price")]
        /// <summary>
        /// Prix au moment de l'achat.
        /// </summary>
        public double Price { get; set; }

        [BsonElement("purchasedAt")]
        /// <summary>
        /// Date/heure de l'achat (UTC).
        /// </summary>
        public DateTime PurchasedAt { get; set; }
    }
}
