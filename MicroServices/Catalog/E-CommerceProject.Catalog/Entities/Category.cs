using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceProject.Catalog.Entities
{
    [BsonIgnoreExtraElements]
    public class Category : IEntity
    {
        [BsonElement("name")]
        public string Name { get; set; }


        public Category()
        {
            Id = Guid.NewGuid().ToString("N");
        }

    }
}
