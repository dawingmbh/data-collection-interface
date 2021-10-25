using Newtonsoft.Json;

namespace DataCollectionInterface
{
    public class DCI_Level
    {
        /// <summary>
        /// This (0-based) index is unique within the list of <see cref="DCI_Format.Levels"/>. It must be
        /// equal to the position in the list.
        /// <para>Note: If used in a <see cref="DCI_TrialUnitSet.Formats"/>, the index is also used
        /// to align the <see cref="DCI_IdValue"/>s of the <see cref="DCI_TrialUnit"/>s</para>
        /// </summary>
        [JsonProperty("level_idx")]
        public int LevelIdx { get; set; }

        /// <summary> If a <see cref="DCI_Trial.Dictionary"/> is provided, this code is used for lookup
        /// of <see cref="DCI_Representation"/>s. If those are not specified, the code itself is used
        /// for display, acoustic feedback and speech recognition</summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>This value can be displayed to the user for additional information. It is only used if
        /// <list type="bullet">
        /// <item>the level belongs to a format within <see cref="DCI_Trait.Formats"/></item>
        /// <item>AND the level has <see cref="DCI_FormatType.IsIdentifying"/> set to true</item></list>
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

    }
}