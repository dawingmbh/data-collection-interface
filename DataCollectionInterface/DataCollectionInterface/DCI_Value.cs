using Newtonsoft.Json;

namespace DataCollectionInterface
{
    /// <summary>These values are used in <see cref="DCI_ValueRange.ValueList"/> to define which values are allowed.
    /// The actual collected data values are of type <seealso cref="DCI_DataValue"/> and are stored within the
    /// <see cref="DCI_Execution.DataValues"/>. </summary>
    public class DCI_Value
    {
        /// <summary> The main purpose of the code is to retrieve the representations for the value.
        /// It is also displayed to the trialist to define representations if none are provided in the dictionary.
        /// If <seealso cref="Storage"/> is not set, the code is also used in <see cref="DCI_DataValue.Value"/>s.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary> Optional. If set, the content of this variable is used in <see cref="DCI_DataValue.Value"/>s.
        /// </summary>
        [JsonProperty("storage", NullValueHandling = NullValueHandling.Ignore)]
        public string Storage { get; set; }
    }
}
