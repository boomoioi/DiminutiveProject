using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WebApplication2
{
    public class Order
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = String.Empty;

        [BsonElement("user_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; } = String.Empty;

        [BsonElement("products")]
        public List<ProductOrder>? Products { get; set; }
    }

    public class ProductOrder
    {
        [BsonElement("product_id")]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; } = string.Empty;

        [BsonElement("quantity")]
        public int Quantity { get; set; }

    }
}
