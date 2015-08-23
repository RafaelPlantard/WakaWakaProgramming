using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models.Summaries
{
    /// <summary>
    /// The operating system returned as the response on the summary request.
    /// </summary>
    [JsonObject]
    public class OperatingSystem : BindableBase
    {
        #region Fields

        private string _digital;
        private int _hours;
        private int _minutes;
        private string _name;
        private float _percent;
        private int _seconds;
        private string _text;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Total logged time for this OS in digital clock format.
        /// </summary>
        [JsonProperty("digital")]
        public string Digital
        {
            get { return _digital; }
            set { SetProperty(ref _digital, value); }
        }

        /// <summary>
        /// Hours portion of logged time for this OS.
        /// </summary>
        [JsonProperty("hours")]
        public int Hours
        {
            get { return _hours; }
            set { SetProperty(ref _hours, value); }
        }

        /// <summary>
        /// Minutes portion of logged time for this OS.
        /// </summary>
        [JsonProperty("minutes")]
        public int Minutes
        {
            get { return _minutes; }
            set { SetProperty(ref _minutes, value); }
        }

        /// <summary>
        /// OS name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Percent of time spent in this OS.
        /// </summary>
        [JsonProperty("percent")]
        public float Percent
        {
            get { return _percent; }
            set { SetProperty(ref _percent, value); }
        }

        /// <summary>
        /// Seconds portion of logged time for this OS.
        /// </summary>
        [JsonProperty("seconds")]
        public int Seconds
        {
            get { return _seconds; }
            set { SetProperty(ref _seconds, value); }
        }

        /// <summary>
        /// Total logged time in human readable format.
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        /// <summary>
        /// Seconds portion of logged time for this OS.
        /// </summary>
        [JsonProperty("total_seconds")]
        public int TotalSeconds
        {
            get { return _totalSeconds; }
            set { SetProperty(ref _totalSeconds, value); }
        }

        #endregion
    }
}