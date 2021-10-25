using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_ValueRange
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_Trial.ValueRanges"/>. It must be
        /// equal to the position in the list.
        /// <para>The index is also referenced by <see cref="DCI_Trait.ValueRangeIdx"/></para>
        /// </summary>
        [JsonProperty("value_range_idx")]
        public int ValueRangeIdx { get; set; }

        /// <summary>See <see cref="DCI_NumberGenerator"/> for how to define supported number ranges for this 
        /// value range.</summary>
        [JsonProperty("number_generators", NullValueHandling = NullValueHandling.Ignore)]
        public List<DCI_NumberGenerator> NumberGenerators { get; set; }

        /// <summary>See <see cref="DCI_DateGenerator"/> for how to define date support for this value range.</summary>
        [JsonProperty("date_generator", NullValueHandling = NullValueHandling.Ignore)]
        public DCI_DateGenerator DateGenerator { get; set; }

        /// <summary>Defines individual <see cref="DCI_Value"/>s that are supported by this value range.</summary>
        [JsonProperty("value_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<DCI_Value> ValueList { get; set; }

        /// <summary>If true, there are no restrictions on the <see cref="DCI_DataValue.Value"/>.
        /// <list type="bullet">
        /// <item>It is highly recommended to avoid this setting, as such data values cannot be evaluated
        /// in an automated fashion in the trial management software.</item>
        /// <item>smatrix only supports this flag for traits that are referenced by <see cref="DCI_Execution.ExecutionTraitSetIdx"/></item>
        /// </list></summary>
        [JsonProperty("allow_free_text")]
        public bool AllowFreeText { get; set; }
    }
}
