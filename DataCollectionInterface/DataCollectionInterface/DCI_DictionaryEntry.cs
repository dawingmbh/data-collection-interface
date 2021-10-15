using Newtonsoft.Json;
using System.Collections.Generic;

namespace DataCollectionInterface
{
    public class DCI_DictionaryEntry
    {
        /// <summary>
        /// The code is a language independent identifyer which is used as the key for 
        /// lookup in the dictionary to fetch the language specific representations.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>Representations can be passed (also for multiple languages) if available, see also
        /// <see cref="DCI_Representation"/></summary>
        [JsonProperty("representations")]
        public List<DCI_Representation> Representations { get; set; }
    }
}
