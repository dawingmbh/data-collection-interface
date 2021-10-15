using Newtonsoft.Json;

namespace DataCollectionInterface
{
    public class DCI_FormatType
    {
        /// <summary>
        /// It is mandatory to have one DCI_Format with this flag set to true, in each <see cref="DCI_TrialUnitSet"/>
        /// and each <see cref="DCI_Trait"/>!
        /// <para>If true, the parent DCI_Format is an identifyer for the trial unit / trait it belongs to.
        /// That means, it is used</para>
        /// <list type="bullet">
        /// <item>as display, so the user can see which trial unit / trait is to be assessed</item>
        /// <item>for acoustic feedback to the user</item>
        /// <item>for navigating within the trial by voice</item>
        /// </list>
        /// Note: By default the "code" of the format is used for all these purposes, but representations
        /// can be defined for each of these separately, and separate per target language.
        /// </summary>
        [JsonProperty("is_identifying")]
        public bool IsIdentifying { get; set; }

        /// <summary>
        /// The DCI_Format is used by trial management software for mapping.
        /// If true, this the format is ignored during the trial execution
        /// unless the format has other flags set additionally.
        /// </summary>
        [JsonProperty("is_pass_through")]
        public bool IsPassThrough { get; set; }

        /// <summary>
        /// If true, the DCI_Format contains additional information that may be used
        /// <list type="bullet">
        /// <item>For additional display to the user</item>
        /// <item>For data evaluation, e.g. to create statistics based on data with certain info</item>
        /// </list>
        /// </summary>
        [JsonProperty("is_info")]
        public bool IsInfo { get; set; }
    }
}
