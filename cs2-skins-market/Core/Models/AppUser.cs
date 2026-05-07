using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace cs2_skins_market.Core.Models
{
    public class AppUser
    {
        private string _id = "";
        private string _username = "";
        private string _passwordHash = "";

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

        [BsonElement("passwordHash")]
        public string PasswordHash
        {
            get => _passwordHash;
            set => _passwordHash = value ?? throw new ArgumentNullException(nameof(value));
        }

        [BsonElement("budget")]
        public double Budget { get; set; }
    }
}
