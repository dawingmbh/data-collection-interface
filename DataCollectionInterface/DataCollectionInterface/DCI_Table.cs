using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace DataCollectionInterface
{
    /// <summary>The table for the data collection is spanned by a <see cref="DCI_TrialUnitSet"/>
    /// and a <see cref="DCI_TraitSet"/>. Both are referenced by their indices</summary>
    [Serializable]
    public class DCI_Table
    {
        /// <summary>The index of the trial unit set to be used</summary>
        [JsonProperty("trial_unit_set_idx")]
        public int TrialUnitSetIdx { get; set; }

        /// <summary>The index of the trait set to be used</summary>
        [JsonProperty("trait_set_idx")]
        public int TraitSetIdx { get; set; }
    }
}
