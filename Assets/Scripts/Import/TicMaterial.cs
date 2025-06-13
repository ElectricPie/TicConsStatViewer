using System;
using Newtonsoft.Json;

namespace Import
{
    [Serializable]
    public class TicMaterial
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("color")]
        public string Color = "";
        [JsonProperty("name")]
        public string Name = "";
        
        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}, Name: {Name}";
        }
    }

    [Serializable]
    public class TicMaterialHead
    {
        private float durability = -1.0f;
        public float attack = -1.0f;
        public float level= -1.0f;
        public float speed= -1.0f;
        public string[] traits;
    }
}