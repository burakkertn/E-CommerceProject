using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceProject.Catalog.Entities
{
    [BsonIgnoreExtraElements]
    public class Product : IEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("price")]
        public decimal Price { get; set; }

        [BsonElement("imageUrl")]
        public string ImageUrl { get; set; }

        [BsonElement("stock")]
        public int Stock { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        public string CategoryId { get; set; }

        [BsonIgnore]
        public Category Category { get; set; }


        public Product()
        {
            Id = Guid.NewGuid().ToString("N");
        }

    }
}
