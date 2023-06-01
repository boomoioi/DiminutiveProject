using Microsoft.VisualBasic;
using MongoDB.Driver;
using MongoDB.Bson;
using WebApplication2.Models;
using static MongoDB.Bson.Serialization.Serializers.SerializerHelper;

namespace WebApplication2.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMongoCollection<Order> _orders;

        public OrderService(IDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _orders = database.GetCollection<Order>(settings.OrderCollectionName);

        }
        public Order GetOrders(string id)
        {
            return _orders.Find(order => order.UserId == id).FirstOrDefault();
        }
        public void AddProduct(string id, ProductOrder productOrder)
        {
            var pushProductDefinition = Builders<Order>.Update.Push(order => order.Products, productOrder);
            _orders.UpdateOne(order => order.UserId == id, pushProductDefinition);
        }
    }
}
