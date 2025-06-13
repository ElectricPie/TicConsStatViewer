using Newtonsoft.Json;

namespace Import
{
    public class TicInfos
    {
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("version_tic_exporter")]
        public string ExporterVersion { get; set; }
        [JsonProperty("version_tic")]
        public string TinkersVersion { get; set; }
        [JsonProperty("mod_list")]
        public ModListData[] ModList { get; set; }
        [JsonProperty("create_time")]
        public long CreateTime { get; set; }

        public override string ToString()
        {
            return $"Source: {Source}, Exporter Version: {ExporterVersion}, Tinkers Version: {TinkersVersion}, Create Time: {CreateTime}";
        }
    }

    public class ModListData
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("version")]
        public string Version { get; set; }
        
        public override string ToString()
        {
            return $"Name: {Name}, ID: {Id}, Version: {Version}";
        }
    }
}