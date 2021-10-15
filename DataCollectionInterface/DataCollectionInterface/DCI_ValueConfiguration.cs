using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_ValueConfiguration
    {
        /// <summary>The string defined in this variable will be used in <see cref="DCI_DataValue.Value"/>
        /// when the user cannot specify a value. This allows to differentiate it from missing data values.</summary>
        [JsonProperty("n_a_representation", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("---")]
        public string NARepresentation { get; set; }

        /// <summary>Restriction for traits that are added by the trialist. Any trait added in the data collection software
        /// may not have more than this specified number of subsamples. If no subsampling is supported by the
        /// trial management software, this value has to be set to 1 (which is the default).
        /// </summary>
        [JsonProperty("max_number_subsamples", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(1)]
        public int MaxNumberSubsamples { get; set; }

        /// <summary>Restriction for traits that are added by the trialist. Any trait added in the data collection software
        /// <list type="bullet">
        /// <item>may use <see cref="DCI_ValueRange.ValueList"/>s if this flag is true</item>
        /// <item>may not use <see cref="DCI_ValueRange.ValueList"/>s if this flag is false. In this case e.g. a
        /// number generator or date generator has to be used for value ranges.</item>
        /// </list></summary>
        [JsonProperty("value_lists_supported", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(true)]
        public bool ValueListsSupported { get; set; }

        /// <summary>Defines the format for traits/value ranges that were added by the trialist. Any added trait that
        /// uses a value range with a <see cref="DCI_ValueRange.DateGenerator"/>, has to use this format as
        /// <see cref="DCI_DateGenerator.Format"/></summary>
        [JsonProperty("date_format", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("yyyy-MM-dd")]
        public string DateFormat { get; set; }

        /// <summary>Defines the format for traits/value ranges that were added by the trialist. Any added trait that
        /// uses a value range with a <see cref="DCI_NumberGenerator"/>, has to use this decimal separator as 
        /// <see cref="DCI_NumberGenerator.DecimalSeparator"/></summary>
        [JsonProperty("decimal_separator", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(".")]
        public string DecimalSeparator { get; set; } = ".";

        /// <summary>Defines the format for traits/value ranges that were added by the trialist. Any added trait that
        /// uses a value range with a <see cref="DCI_NumberGenerator"/>, has to use this group separator as 
        /// <see cref="DCI_NumberGenerator.GroupSeparator"/></summary>
        [JsonProperty("group_separator", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("")]
        public string GroupSeparator { get; set; } = string.Empty;
    }
}