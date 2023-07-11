using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_TrialUnitSet
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_Trial.TrialUnitSets"/>. It must be
        /// equal to the position in the list.
        /// <para>This index is also refered to by <see cref="DCI_Table.TrialUnitSetIdx"/>s within one or more 
        /// <see cref="DCI_Execution"/>s</para></summary>
        [JsonProperty("trial_unit_set_idx")]
        public int TrialUnitSetIdx { get; set; }

        /// <summary>The list of formats define which information is provided for each <see cref="DCI_TrialUnit"/>s
        /// and how it can be used in the data collection software.</summary>
        [JsonProperty("formats")]
        public List<DCI_Format> Formats { get; set; }

        /// <summary>The trial units contain the read-only <see cref="DCI_IdValue"/>s for each format/level</summary>
        [JsonProperty("trial_units")]
        public List<DCI_TrialUnit> TrialUnits { get; set; }
    }
}

