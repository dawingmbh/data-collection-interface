using Newtonsoft.Json;
using System.ComponentModel;

namespace DataCollectionInterface
{
    /// <summary>Is part of a <see cref="DCI_TrialUnit"/> and contains values for each of the formats/levels
    /// defined in the <see cref="DCI_TrialUnitSet"/> </summary>
    public class DCI_IdValue
    {
        /// <summary>This value Refers to one format in <see cref="DCI_TrialUnitSet.Formats"/></summary>
        [JsonProperty("format_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public int FormatIdx { get; set; }

        /// <summary>Refers to one level within the format pointed out by <see cref="FormatIdx"/></summary>
        [JsonProperty("level_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public int LevelIdx { get; set; }

        /// <summary>The value belonging to the level pointed out by <see cref="LevelIdx"/>
        /// and <see cref="FormatIdx"/></summary>
        [JsonProperty("value")] 
        public string Value { get; set; }
    }
}
