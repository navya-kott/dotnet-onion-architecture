using MongoDB.Bson.Serialization.Attributes;

namespace Onion.Core.Models
{
   public class Blog
    {

        private string? _publisher;

        [BsonId]
        public required string Id { get; set; }

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

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
