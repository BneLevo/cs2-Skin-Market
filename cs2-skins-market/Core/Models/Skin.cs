using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    public class Skin
    {
        private string _id = "";
        private string _name = "";
        private string _img = "";
        private string _item = "";
        private string _skinName = "";

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id
        {
            get => _id;
            set => _id = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("name")]
        public string Name
        {
            get => _name;
            set => _name = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("img")]
        public string Img
        {
            get => _img;
            set => _img = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("item")]
        public string Item
        {
            get => _item;
            set => _item = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("skinName")]
        public string SkinName
        {
            get => _skinName;
            set => _skinName = value ?? throw new ArgumentNullException(nameof(value));
        }
    }
}
