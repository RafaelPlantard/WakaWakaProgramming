using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A hearbeat that is sent from plugins.
    /// </summary>
    [JsonObject]
    public class HeartBeat : HeartBeatBase
    {
        #region Properties

        /// <summary>
        /// Project name.
        /// </summary>
        [JsonProperty("project")]
        public string Project { get; set; }

        /// <summary>
        /// Branch name.
        /// </summary>
        [JsonProperty("branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Language name.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Comma separated list of dependencies detected from entity file.
        /// </summary>
        [JsonProperty("dependencies")]
        public string Dependencies { get; set; }

        /// <summary>
        /// Total number of lines in the entity (when entity type is file).
        /// </summary>
        [JsonProperty("lines")]
        public int Lines { get; set; }

        /// <summary>
        /// Current line row number of cursor.
        /// </summary>
        [JsonProperty("lineno")]
        public int LineNumbers { get; set; }

        /// <summary>
        /// Current cursor column position.
        /// </summary>
        [JsonProperty("cursorpos")]
        public int CursorPosition { get; set; }

        /// <summary>
        /// Whether this heartbeat was triggered from writing to a file.
        /// </summary>
        [JsonProperty("is_write")]
        public bool IsWrite { get; set; }

        /// <summary>
        /// Whether this heartbeat was triggered while debuggging.
        /// </summary>
        [JsonProperty("is_debugging")]
        public bool IsDebugging { get; set; }

        #endregion
    }
}
