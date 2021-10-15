using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_NumberGenerator
    {
        /// <summary>The first number (included) that is supported by the number generator.</summary>
        [JsonProperty("from")]
        public int From { get; set; }

        /// <summary>The last number (included) that is supported by the number generator.
        /// Must be larger than <see cref="From"/></summary>
        [JsonProperty("to")]
        public int To { get; set; }

        /// <summary>Corresponds to the step-size when generating numbers between <see cref="From"/> and
        /// <see cref="To"/>. May have maximum 3 decimals</summary>
        [JsonProperty("by", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(1)]
        public decimal By { get; set; }

        /// <summary>This decimal separator is used in all <see cref="DCI_DataValue.Value"/> strings that belong
        /// to a <see cref="DCI_Trait"/> referring to the <see cref="DCI_ValueRange"/> owning this number generator.
        /// <para>Must be different from <see cref="GroupSeparator"/>!</para></summary>
        [JsonProperty("decimal_separator", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(".")]
        public string DecimalSeparator { get; set; } = ".";

        /// <summary>This group separator is used in all <see cref="DCI_DataValue.Value"/> strings that belong
        /// to a <see cref="DCI_Trait"/> referring to the <see cref="DCI_ValueRange"/> owning this number generator.
        /// <para>Must be different from <see cref="DecimalSeparator"/>!</para></summary>
        [JsonProperty("group_separator", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("")]
        public string GroupSeparator { get; set; } = string.Empty;
    }
}
