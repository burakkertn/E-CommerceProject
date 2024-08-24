using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceProject.Catalog.Entities
{
    [BsonIgnoreExtraElements]
    public class ProductImage : IEntity
    {
        [BsonElement("image1")]
        public string Image1 { get; set; }

        [BsonElement("image2")]
        public string Image2 { get; set; }

        [BsonElement("image3")]
        public string Image3 { get; set; }

        public string ProductId { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }


        public ProductImage()
        {
            Id = Guid.NewGuid().ToString("N");
        }

    }
}
