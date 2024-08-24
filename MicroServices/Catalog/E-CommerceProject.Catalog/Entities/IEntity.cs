using MongoDB.Bson.Serialization.Attributes;

namespace E_CommerceProject.Catalog.Entities
{
    public class IEntity
    {
        [BsonId]
        public string Id { get; set; }
    }
}
