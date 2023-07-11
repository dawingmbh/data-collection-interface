using Newtonsoft.Json;
using System.ComponentModel;


namespace DataCollectionInterface
{
    public class DCI_Comment
    {
        /// <summary>The text string of the comment</summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>The index of the trait this comment refers to</summary>
        [JsonProperty("trait_idx")]
        public int TraitIdx { get; set; }

        /// <summary>The index of the trial unit this comment refers to.
        /// It might be -1 if the comment refers to a trait per execution </summary>
        [JsonProperty("trial_unit_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(-1)]
        public int TrialUnitIdx { get; set; }

        /// <summary>The subsample index this comment refers to.  If not specified, it defaults to 0</summary>
        [JsonProperty("subsample_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(0)]
        public int SubsampleIdx { get; set; }
    }
}
