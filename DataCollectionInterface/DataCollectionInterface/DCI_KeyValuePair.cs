using Newtonsoft.Json;

namespace DataCollectionInterface
{
    /// <summary>Simple pair of key and value strings. They are readonly-fields and are only used
    /// for display of additional information.</summary>
    public class DCI_KeyValuePair
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
