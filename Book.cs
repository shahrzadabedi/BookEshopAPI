using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreAPI
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        // <snippet_BookNameProperty>
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string BookName { get; set; }
        // </snippet_BookNameProperty>

        public decimal Price { get; set; }
        public string Pages { get; set; }
        public string Category { get; set; }

        public string Author { get; set; }
    }
}
