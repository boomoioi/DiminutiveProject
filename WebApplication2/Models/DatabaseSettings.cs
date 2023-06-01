namespace WebApplication2.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string UserCollectionName { get; set; } = String.Empty;
        public string OrderCollectionName { get; set; } = String.Empty;
        public string ProductCollectionName { get; set; } = String.Empty;
        public string ReceiptCollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set;} = String.Empty;
        public string DatabaseName { get; set;} = String.Empty;
    }
}
