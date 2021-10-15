using Newtonsoft.Json;

namespace DataCollectionInterface
{
    public class DCI_SoftwareDescription
    {
        /// <summary>Name of the trial management software where this trial was created.</summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>Optional. The software version of the trial management software (just for debugging purposes)</summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
