using Newtonsoft.Json;
using System.ComponentModel;

namespace DataCollectionInterface
{
    public class DCI_DataValue
    {
        /// <summary>
        /// The actual data value, which 
        /// <list type="bullet">
        /// <item>must be part of the ValueRange used by the trait, or equal to the n_a_represenation</item>
        /// <item>must be formatted according to the value range definition</item>
        /// </list>
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The index of the trial unit this data value refers to.
        /// It is -1 if the data value refers to a trait per execution
        /// </summary>
        [JsonProperty("trial_unit_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(-1)]
        public int TrialUnitIdx { get; set; }

        /// <summary>The index of the trait this data value refers to</summary>
        [JsonProperty("trait_idx")]
        public int TraitIdx { get; set; }

        /// <summary>The subsample index this data value refers to. If not specified, it defaults to 0</summary>
        [JsonProperty("subsample_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public int? SubsampleIdx { get; set; }
    }
}
