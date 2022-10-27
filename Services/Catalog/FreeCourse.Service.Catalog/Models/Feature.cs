using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FreeCourse.Service.Catalog.Models
{
    public class Feature
    {
        [BsonRepresentation(BsonType.Int32)]
        public int Duration { get; set; }
    }
}