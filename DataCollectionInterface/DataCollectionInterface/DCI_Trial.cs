using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_Trial
    {
        public const string currentVersion = "1.0";
        /// <summary>
        /// Defined by a string concatenated by two numbers major.minor using a dot as separator e.g. "1.0"
        /// </summary>
        [JsonProperty("interface_version", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue(currentVersion)]
        public string InterfaceVersion { get; set; } = currentVersion;

        /// <summary>Information on the trial management software that created this trial</summary>
        [JsonProperty("trial_management_software")]
        public DCI_SoftwareDescription TrialManagementSoftware { get; set; }

        /// <summary>Optional. This identifier can be used for automatic alignment of the trial in the trial
        /// management software</summary>
        [JsonProperty("trial_identifier")]
        public string TrialIdentifier { get; set; }

        /// <summary>Optional name to be displayed in the data collection software to identify the trial</summary>
        [JsonProperty("trial_display_name")]
        public string TrialDisplayName { get; set; }

        /// <summary>Optional read-only information of the trial as <see cref="DCI_KeyValuePair"/>s. It can be used
        /// for additional display to the trialist</summary>
        [JsonProperty("trial_information", NullValueHandling = NullValueHandling.Ignore)]
        public List<DCI_KeyValuePair> TrialInformation { get; set; }

        /// <summary>The definition of trial unit sets, which can be used in <see cref="DCI_Execution"/>s</summary>
        [JsonProperty("trial_unit_sets")]
        public List<DCI_TrialUnitSet> TrialUnitSets { get; set; }

        /// <summary>The definition of trait sets, which can be used in <see cref="DCI_Execution"/>s</summary>
        [JsonProperty("trait_sets")]
        public List<DCI_TraitSet> TraitSets { get; set; }

        /// <summary>The executions define, for which <see cref="DCI_Table"/> and 
        /// <see cref="DCI_Execution.ExecutionTraitSetIdx"/> data has to be collected.
        /// <para>After the collection, this structure also contains the <see cref="DCI_DataValue"/>s</para></summary>
        [JsonProperty("executions")]
        public List<DCI_Execution> Executions { get; set; }

        /// <summary>The definition of the value ranges are used for validation and formatting of all
        /// <see cref="DCI_DataValue.Value"/>. The <see cref="DCI_Trait.ValueRangeIdx"/> defines which
        /// value range is to be used.</summary>
        [JsonProperty("value_ranges")]
        public List<DCI_ValueRange> ValueRanges { get; set; }

        /// <summary>Defines which formatting is used for traits that were added by the trialist.</summary>
        [JsonProperty("value_configuration")]
        public DCI_ValueConfiguration ValueConfiguration { get; set; }

        /// <summary>The optional dictionary can provide representations for all <see cref="DCI_Level.Code"/>s
        /// per culture.</summary>
        [JsonProperty("dictionary")]
        public List<DCI_DictionaryEntry> Dictionary { get; set; }
    }
}
