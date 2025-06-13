using Newtonsoft.Json;

namespace Import
{
    public class TicMaterial
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("color")]
        public string Color = "";
        [JsonProperty("name")]
        public string Name = "";
        [JsonProperty("head")]
        public TicMaterialHead Head { get; set; }
        [JsonProperty("handle")]
        public TicMaterialHandle Handle { get; set; }
        [JsonProperty("extra")]
        public TicMaterialExtra Extra { get; set; }
        [JsonProperty("bow")]
        public TicMaterialBow Bow { get; set; }
        [JsonProperty("core")]
        public TicMaterialCore Core { get; set; }
        [JsonProperty("plate")]
        public TicMaterialPlate Plate { get; set; }
        [JsonProperty("trim")]
        public TicMaterialTrim Trim { get; set; }
        [JsonProperty("string")]
        public TicMaterialString String { get; set; }
        [JsonProperty("shaft")]
        public TicMaterialShaft Shaft { get; set; }
        [JsonProperty("fletching")]
        public TicMaterialFletching Fletching { get; set; }
        
        public override string ToString()
        {
            return $"Id: {Id}, Color: {Color}, Name: {Name}";
        }
    }

    public class TicMaterialHead
    {
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("attack")]
        public float Attack { get; set; }
        [JsonProperty("level")]
        public float Level { get; set; }
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Durability: {Durability}, Attack: {Attack}, Level: {Level}, Speed: {Speed}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialHandle
    {
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("modifier")]
        public float Modifier { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Durability: {Durability}, Modifier: {Modifier}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialExtra
    {
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Durability: {Durability}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialBow
    {
        [JsonProperty("damage")]
        public float Damage { get; set; }
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("range")]
        public float Range { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Damage: {Damage}, Speed: {Speed}, Range: {Range}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialCore
    {
        [JsonProperty("defense")]
        public float Defense { get; set; }
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Defence: {Defense}, Durability: {Durability}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialPlate
    {
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("modifier")]
        public float Modifier { get; set; }
        [JsonProperty("toughness")]
        public float Toughness { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Durability: {Durability}, Modifier: {Modifier}, Toughness: {Toughness}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialTrim
    {
        [JsonProperty("durability")]
        public float Durability { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Durability: {Durability}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialString
    {
        [JsonProperty("modifier")]
        public float Modifier { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Modifier: {Modifier}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialShaft
    {
        [JsonProperty("ammo")]
        public float Ammo { get; set; }
        [JsonProperty("modifier")]
        public float Modifier { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Ammo: {Ammo}, Modifier: {Modifier}, Traits: {string.Join(", ", Traits)}";
        }
    }

    public class TicMaterialFletching
    {
        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }
        [JsonProperty("modifier")]
        public float Modifier { get; set; }
        [JsonProperty("traits")]
        public string[] Traits { get; set; }
        
        public override string ToString()
        {
            return $"Accuracy: {Accuracy}, Modifier: {Modifier}, Traits: {string.Join(", ", Traits)}";
        }
    }
}