using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceProject.Catalog.Entities
{
    [BsonIgnoreExtraElements]
    public class ProductDetail : IEntity
    {
        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("info")]
        public string Info { get; set; }
        public string ProductId { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }

        public ProductDetail()
        {
            Id = Guid.NewGuid().ToString("N");
        }

    }
}
