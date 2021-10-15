using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataCollectionInterface
{
    public class DCI_TrialUnit
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_TrialUnitSet.TrialUnits"/>. It must be
        /// equal to the position in the list.
        /// <para>Note: the index is also used to align the <see cref="DCI_DataValue"/>s to this trial unit</para>
        /// </summary>
        [JsonProperty("trial_unit_idx")]
        public int TrialUnitIdx { get; set; }

        /// <summary>The <see cref="DCI_IdValue"/>s contains values for each of the formats/levels
        /// defined in the <see cref="DCI_TrialUnitSet"/> this trial unit belongs to</summary>
        [JsonProperty("id_values")]
        public List<DCI_IdValue> IdValues { get; set; }

    }
}
