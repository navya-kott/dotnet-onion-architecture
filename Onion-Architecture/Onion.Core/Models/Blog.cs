using MongoDB.Bson.Serialization.Attributes;

namespace Onion.Core.Models
{
   public class Blog
    {

        private string? _publisher;

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public  string? Id { get; set; }

        public required string Content { get; set; }

        public required string Publisher
        {
            get => _publisher!;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _publisher = "Aknjathan";
                }
                else
                {
                    _publisher = value;
                }
            }
        }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
