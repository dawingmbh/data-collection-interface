using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_Trait
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_TraitSet.Traits"/>. It must be
        /// equal to the position in the list.
        /// <para>Note: the index is also used to align the <see cref="DCI_DataValue"/>s to this trait</para>
        /// </summary>
        [JsonProperty("trait_idx")]
        public int TraitIdx { get; set; }

        /// <summary>This list of <see cref="DCI_Format"/>s describes what the trait.</summary>
        [JsonProperty("formats")]
        public List<DCI_Format> Formats { get; set; }


        /// <summary>This index is used to look up the complete <see cref="DCI_ValueRange"/> definition
        /// in the list of <see cref="DCI_Trial.ValueRanges"/>. All <see cref="DCI_DataValue"/>s referring to
        /// this trait must be part of the value range (except for n_a_representation).
        /// </summary>
        [JsonProperty("value_range_idx")]
        public int ValueRangeIdx { get; set; }

        /// <summary>
        /// Optional parameter defining how many subsamples need to be collected per trait/trial unit
        /// combination. Defaults to 1 for traits that don't use subsamples
        /// </summary>
        [JsonProperty("subsample_count",DefaultValueHandling=DefaultValueHandling.Populate)]
        [DefaultValue(1)]
        public int SubsampleCount { get; set; }
    }
}
