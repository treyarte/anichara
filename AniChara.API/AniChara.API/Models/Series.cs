using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace AniChara.API.Models
{
    [BsonIgnoreExtraElements]
    public class Series
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [JsonProperty("id")]
        public string Id { get; set; }
        [BsonElement("title")]
        [JsonProperty("title")]
        public string Title { get; set; }
        [BsonElement("image_url")]
        [JsonProperty("image")]
        public string Image { get; set; }
        [BsonElement("description")]
        [JsonProperty("description")]
        public string Description { get; set; }
        [BsonElement("format")]
        [JsonProperty("format")]
        public string Format { get; set; }
        [BsonElement("source")]
        [JsonProperty("source")]
        public string Source { get; set; }
        [BsonElement("episodes")]
        [JsonProperty("episodes")]
        public int Episodes { get; set; }
        [BsonElement("run_time")]
        [JsonProperty("run_time")]
        public int RunTime { get; set; }
        [BsonElement("premiere")]
        [JsonProperty("premiere")]
        public DateTime Premiere { get; set; }
        [BsonElement("tags")]
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [BsonElement("studios")]
        [JsonProperty("studios")]
        public List<string> Studios { get; set; }


    }
}
