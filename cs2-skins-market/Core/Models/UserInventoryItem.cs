using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    public class InventoryItem
    {
        private string _id = "";
        private string _username = "";
        private string _skinId = "";
        private string _name = "";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get => _id;
            set => _id = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("username")]
        public string Username
        {
            get => _username;
            set => _username = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("skinId")]
        public string SkinId
        {
            get => _skinId;
            set => _skinId = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("name")]
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("purchasedAt")]
        public DateTime PurchasedAt { get; set; }
    }
}
