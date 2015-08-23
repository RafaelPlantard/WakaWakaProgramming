using System;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// Represents a more specific programming language details.
    /// </summary>
    [JsonObject]
    public class ProgrammingLanguage : ProgrammingLanguageBase
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
        [JsonProperty("percent")]
        public double Percent { get; set; }

        #endregion
    }
}
