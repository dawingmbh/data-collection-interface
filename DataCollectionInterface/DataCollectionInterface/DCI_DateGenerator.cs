using Newtonsoft.Json;
using System.ComponentModel;

namespace DataCollectionInterface
{
    [Serializable]
    public class DCI_DateGenerator
    {
        /// <summary> Defines the format of dates in the data values.
        /// Valid values for date format are:
        /// yyyy-MM-dd (default), yyyyMMdd, yyyy/MM/dd, dd/MM/yyyy, dd.MM.yyyy, d.m.yyyy, dd-MM-yyyy, MM/dd/yyyy, DayOfYear
        /// any other formatting-string will default to yyyy-MM-dd.
        /// </summary>
        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Populate)]
        [DefaultValue("yyyy-MM-dd")]
        public string Format { get; set; }
    }
}
