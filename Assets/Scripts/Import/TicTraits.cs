using Newtonsoft.Json;

namespace Import
{
    public class TicTraits
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("desc")]
        public string Description { get; set; }
        [JsonProperty("hidden")]
        public bool IsHidden { get; set; }
        [JsonProperty("priority")]
        public float Priority { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, Hidden: {IsHidden}, Priority: {Priority}, Color: {Color}";
        }
    }
}