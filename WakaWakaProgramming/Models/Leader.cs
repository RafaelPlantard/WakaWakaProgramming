using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject]
    public class Leader : BindableBase
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("rank")]
        public int Rank { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("running_total")]
        public RunningTotal Running { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        #endregion
    }
}