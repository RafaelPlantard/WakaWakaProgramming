using System;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject]
    public class OperatingSystem : BindableBase
    {
        #region Fields

        #endregion

        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("modified_at")]
        public DateTime ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("percent")]
        public int Percent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_seconds")]
        public int TotalSeconds { get; set; }

        #endregion
    }
}
