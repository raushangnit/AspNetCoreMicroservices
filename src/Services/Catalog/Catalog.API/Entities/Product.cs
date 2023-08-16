using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catelog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement]
        public string  Name { get; set; }

        [BsonElement]
        public string Summary { get; set; }

        [BsonElement]
        public string Category { get; set; }

        [BsonElement]
        public string Description { get; set; }

        [BsonElement]
        public string ImageFile { get; set; }

        [BsonElement]
        public decimal Price { get; set; }

    }
}
