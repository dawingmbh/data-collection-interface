using Newtonsoft.Json;

namespace DataCollectionInterface
{
    public class DCI_Representation 
    {
        /// <summary>The text of the representation</summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>The culture for which this represenation should be used.
        /// Valid values are ISO 639-1 two-letter language codes.
        /// </summary>
        [JsonProperty("culture")]
        public string Culture { get; set; }

        /// <summary>If true, this representation shall be used for display.
        /// <para>Exactly one representation per code and culture must have this flag set to true!</para></summary>
        [JsonProperty("for_display")]
        public bool IsUsedForDisplay { get; set; }

        /// <summary>If true, this representation shall be used for acoustic feedback.
        /// <para>Exactly one representation per code and culture must have this flag set to true!</para></summary>
        [JsonProperty("for_tts")]
        public bool IsUsedForTts { get; set; }

        /// <summary>If true, this representation shall be used for speech recognition.
        /// <para>At least one representation per code and culture must have this flag set to true!</para></summary>
        [JsonProperty("for_asr")]
        public bool IsUsedForAsr { get; set; }
    }
}
