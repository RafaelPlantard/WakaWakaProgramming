using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// Represents a block of time duration on a specific day of a user.
    /// </summary>
    [JsonObject]
    public class DurationBlock : BindableBase
    {
        #region Fields

        private string _dependencies;
        private int _duration;
        private bool _isDebugging;
        private string _project;
        private double _time;
        private string _type;

        #endregion

        #region Properties

        /// <summary>
        /// A json list of dependencies in the current project.
        /// </summary>
        [JsonProperty("dependencies")]
        public string Dependencies
        {
            get { return _dependencies; }
            set { SetProperty(ref _dependencies, value); }
        }

        /// <summary>
        /// Length of time of this duration in seconds.
        /// </summary>
        [JsonProperty("duration")]
        public int Duration
        {
            get { return _duration; }
            set { SetProperty(ref _duration, value); }
        }

        /// <summary>
        /// A boolean that indicates whether the API is debugging or not.
        /// </summary>
        [JsonProperty("is_debugging")]
        public bool IsDebugging
        {
            get { return _isDebugging; }
            set { SetProperty(ref _isDebugging, value); }
        }

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
        /// Start of this duration as UNIX epoch timestamp; numbers after decimal point are fractions of a second.
        /// </summary>
        [JsonProperty("time")]
        public double Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        /// <summary>
        /// The type of thing is working in.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        #endregion
    }
}
