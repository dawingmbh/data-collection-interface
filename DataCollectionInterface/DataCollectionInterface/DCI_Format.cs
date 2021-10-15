using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataCollectionInterface
{
    public class DCI_Format
    {
        /// <summary>
        /// The (0-based) index is unique within the array of formats of a trait or a trial unit set.
        /// Its index must match the position within the array of formats.
        /// <para>Note: If used in trial unit set, <see cref="DCI_IdValue"/>s refered to this index.</para> 
        /// </summary>
        [JsonProperty("format_idx")]
        public int FormatIdx { get; set; }

        /// <summary>Defines how this format is to be used in the data collection software, 
        /// see <see cref="DCI_FormatType"/> </summary>
        [JsonProperty("format_type")]
        public DCI_FormatType FormatType { get; set; }

        /// <summary>The list of <see cref="DCI_Level"/>s <list type="bullet">
        /// <item>contains information to be used according to the <see cref="DCI_FormatType"/></item>
        /// <item>are a grouping the levels, so they can form a hierarchy</item></list></summary>
        [JsonProperty("levels")]
        public List<DCI_Level> Levels { get; set; }
    }
}
