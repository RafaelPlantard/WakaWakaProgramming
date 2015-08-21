using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject]
    public class DurationBlock : BindableBase
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("dependencies")]
        public string Dependencies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("is_debugging")]
        public bool IsDebugging { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("project")]
        public string Project { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("time")]
        public double Time { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }  

        #endregion
    }
}
