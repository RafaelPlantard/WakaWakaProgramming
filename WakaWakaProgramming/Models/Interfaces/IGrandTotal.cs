using Newtonsoft.Json;

namespace WakaWakaProgramming.Models.Interfaces
{
    /// <summary>
    /// The prototype for the data based in time spend for a user.
    /// </summary>
    public interface IGrandTotal
    {
        #region Properties

        /// <summary>
        /// The time in digital format.
        /// </summary>
        [JsonProperty]
        string Digital { get; set; }

        /// <summary>
        /// The hours portion.
        /// </summary>
        [JsonProperty]
        int Hours { get; set; }

        /// <summary>
        /// The minutes portion.
        /// </summary>
        [JsonProperty]
        int Minutes { get; set; }

        /// <summary>
        /// The time formatted as text.
        /// </summary>
        [JsonProperty]
        string Text { get; set; }

        /// <summary>
        /// The time in seconds.
        /// </summary>
        [JsonProperty]
        long TotalSeconds { get; set; }

        #endregion
    }
}
