using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_Execution
    {
        /// <summary>The unique (0-based) index of the execution. It must correspond to the
        /// position if this execution in the array of executions.
        /// </summary>
        [JsonProperty("execution_idx")]
        public int ExecutionIdx { get; set; }

        /// <summary> Optional field. It makes sense only for trials with multiple executions.
        /// The information will not be shown to the user, but can be used for alignement in the 
        /// trial management software when importing the collected data.
        /// </summary>
        [JsonProperty("identifier", NullValueHandling = NullValueHandling.Ignore)]
        public string Identifier { get; set; }

        /// <summary>Defines the <see cref="DCI_Table"/> used in this execution.</summary>
        [JsonProperty("table")]
        public DCI_Table Table { get; set; }

        /// <summary>
        /// Additional trait set for the whole execution.
        /// Can be used, to collect values that are independent of the trial units e.g. BBCH values
        /// </summary>
        [JsonProperty("execution_trait_set_idx", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(-1)]
        public int ExecutionTraitSetIdx { get; set; } = -1;

        /// <summary>The list of <see cref="DCI_DataValue"/>s that were collected for this execution </summary>
        [JsonProperty("data_values", NullValueHandling = NullValueHandling.Ignore)]
        public List<DCI_DataValue> DataValues { get; set; }

        /// <summary>The list of <see cref="DCI_Comment"/>s that were collected for this execution </summary>
        [JsonProperty("comments", NullValueHandling = NullValueHandling.Ignore)]
        public List<DCI_Comment> Comments { get; set; }
    }
}

