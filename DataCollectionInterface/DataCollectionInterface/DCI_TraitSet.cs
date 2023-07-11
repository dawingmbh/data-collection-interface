using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_TraitSet
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_Trial.TraitSets"/>. It must be
        /// equal to the position in the list.
        /// <para>Note: The trait set can be referenced by multiple <see cref="DCI_Table.TraitSetIdx"/> and/or
        /// <see cref="DCI_Execution.ExecutionTraitSetIdx"/></para>
        /// </summary>
        [JsonProperty("trait_set_idx")]
        public int TraitSetIdx { get; set; }

        /// <summary>The list of <see cref="DCI_Trait"/>s grouped in this trait set.</summary>
        [JsonProperty("traits")]
        public List<DCI_Trait> Traits { get; set; }
    }
}
