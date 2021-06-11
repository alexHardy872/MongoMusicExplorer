using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoMusicExplorer.Models
{
    public class Album
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }

        [BsonElement("Name")]
        public string artist { get; set; }

        public int year { get; set; }

        public string album { get; set; }

        public string length { get; set; }

        public List<string> genre { get; set; }

        public Uri imageUrl { get; set; }

    }
}




