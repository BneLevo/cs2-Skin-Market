using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    public class Skin
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("img")]
        public string Img { get; set; }

        [BsonElement("price")]
        public double Price { get; set; }

        [BsonElement("item")]
        public string Item { get; set; }

        [BsonElement("skinName")]
        public string SkinName { get; set; }
    }
}
