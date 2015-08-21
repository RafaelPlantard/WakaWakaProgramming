using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The basic structure of heart beats.
    /// </summary>
    [JsonObject]
    public class HeartBeatBase : BindableBase
    {
        #region Properties

        /// <summary>
        /// Unique id of newly created heartbeat.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Entity heartbeat is logging time against, such as an absolute file path or domain.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// Type of entity; can be file or domain.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// UNIX epoch timestamp; numbers after decimal point are fractions of a second.
        /// </summary>
        [JsonProperty("time")]
        public double Time { get; set; }

        #endregion
    }
}
