/**************************************************************************
* Nom du fichier : Skin.cs
* Auteur : Ozgun Levent
* Date de création : 30.04.2026
* Description : Modèle représentant un skin du marketplace.
**************************************************************************/

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    /// <summary>
    /// Représente un skin disponible dans le marketplace.
    /// </summary>
    public class Skin
    {
        private string _id = "";
        private string _name = "";
        private string _img = "";
        private string _item = "";
        private string _skinName = "";

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

        [BsonElement("name")]
        /// <summary>
        /// Nom du skin.
        /// </summary>
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("img")]
        /// <summary>
        /// URL ou chemin de l'image du skin.
        /// </summary>
        public string Img
        {
            get => _img;
            set => _img = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("price")]
        /// <summary>
        /// Prix actuel du skin.
        /// </summary>
        public double Price { get; set; }

        [BsonElement("item")]
        /// <summary>
        /// Catégorie/Item du skin.
        /// </summary>
        public string Item
        {
            get => _item;
            set => _item = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("skinName")]
        /// <summary>
        /// Nom interne (skinName) du skin.
        /// </summary>
        public string SkinName
        {
            get => _skinName;
            set => _skinName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
