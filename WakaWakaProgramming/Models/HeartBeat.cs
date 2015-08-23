using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A hearbeat that is sent from plugins.
    /// </summary>
    [JsonObject]
    public class HeartBeat : HeartBeatBase
    {
        #region Fields

        private string _branch;
        private int _cursorPosition;
        private string _dependencies;
        private bool _isDebugging;
        private bool _isWrite;
        private string _language;
        private int _lines;
        private int _lineNumber;
        private string _project;

        #endregion

        #region Properties

        /// <summary>
        /// Project name.
        /// </summary>
        [JsonProperty("project")]
        public string Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        /// <summary>
        /// Branch name.
        /// </summary>
        [JsonProperty("branch")]
        public string Branch
        {
            get { return _branch; }
            set { SetProperty(ref _branch, value); }
        }

        /// <summary>
        /// Current cursor column position.
        /// </summary>
        [JsonProperty("cursorpos")]
        public int CursorPosition
        {
            get { return _cursorPosition; }
            set { SetProperty(ref _cursorPosition, value); }
        }

        /// <summary>
        /// Comma separated list of dependencies detected from entity file.
        /// </summary>
        [JsonProperty("dependencies")]
        public string Dependencies
        {
            get { return _dependencies; }
            set { SetProperty(ref _dependencies, value); }
        }

        /// <summary>
        /// Whether this heartbeat was triggered while debuggging.
        /// </summary>
        [JsonProperty("is_debugging")]
        public bool IsDebugging
        {
            get { return _isDebugging; }
            set { SetProperty(ref _isDebugging, value); }
        }

        /// <summary>
        /// Whether this heartbeat was triggered from writing to a file.
        /// </summary>
        [JsonProperty("is_write")]
        public bool IsWrite
        {
            get { return _isWrite; }
            set { SetProperty(ref _isWrite, value); }
        }

        /// <summary>
        /// Language name.
        /// </summary>
        [JsonProperty("language")]
        public string Language
        {
            get { return _language; }
            set { SetProperty(ref _language, value); }
        }

        /// <summary>
        /// Total number of lines in the entity (when entity type is file).
        /// </summary>
        [JsonProperty("lines")]
        public int Lines
        {
            get { return _lines; }
            set { SetProperty(ref _lines, value); }
        }

        /// <summary>
        /// Current line row number of cursor.
        /// </summary>
        [JsonProperty("lineno")]
        public int LineNumber
        {
            get { return _lineNumber; }
            set { SetProperty(ref _lineNumber, value); }
        }

        #endregion
    }
}
