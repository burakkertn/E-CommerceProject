namespace E_CommerceProject.Catalog.MongoSettings
{
    public class MongoDbSettings : IMongoDbSettings
    {
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; } 
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string? Database { get; set; }
        public string? ConnectionString { get; set; }
    }
}

