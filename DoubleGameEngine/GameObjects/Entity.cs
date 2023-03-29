using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DoubleGameEngine.GameObjects
{
    /// <summary>
    /// Сущность на уровне
    /// </summary>
    public class Entity
    {
        [JsonPropertyName("id")]
        public string Type { get; set; }
        [JsonPropertyName("iid")]
        public string Id { get; set; }
        [JsonPropertyName("x")]
        public int X { get; set; }
        [JsonPropertyName("y")]
        public int Y { get; set; }
        [JsonPropertyName("width")]
        public int Width { get; set; }
        [JsonPropertyName("height")]
        public int Height { get; set; }
        [JsonPropertyName("customFields")]
        public Dictionary<string, object> CustomFields { get; set; }
    }
}
