namespace WebApplication2.Services
{
    public interface IOrderService
    {
        Order GetOrders(string id);
        void AddProduct(string id, ProductOrder productOrder);
    }
}