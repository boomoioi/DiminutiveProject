namespace WebApplication2.Models
{
    public interface IDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string OrderCollectionName { get; set; }
        string ProductCollectionName { get; set; }
        string ReceiptCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
