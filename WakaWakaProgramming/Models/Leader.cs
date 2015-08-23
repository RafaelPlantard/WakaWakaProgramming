using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;
using WakaWakaProgramming.Models.Users;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The leader data.
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
        /// The user data.
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }

        #endregion
    }
}