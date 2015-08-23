using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The editor returned when the summary is requested.
    /// </summary>
    public class Editor : BindableBase
    {
        #region Fields

        private string _digital;
        private int _hours;
        private int _minutes;
        private string _name;
        private double _percent;
        private int _seconds;
        private string _text;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Total logged time for this editor in digital clock format.
        /// </summary>
        [JsonProperty("digital")]
        public string Digital
        {
            get { return _digital; }
            set { SetProperty(ref _digital, value); }
        }

        /// <summary>
        /// Hours portion of logged time for this editor.
        /// </summary>
        [JsonProperty("hours")]
        public int Hours
        {
            get { return _hours; }
            set { SetProperty(ref _hours, value); }
        }

        /// <summary>
        /// Minutes portion of logged time for this editor.
        /// </summary>
        [JsonProperty("minutes")]
        public int Minutes
        {
            get { return _minutes; }
            set { SetProperty(ref _minutes, value); }
        }

        /// <summary>
        /// Editor name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Percent of time spent in this editor.
        /// </summary>
        [JsonProperty("percent")]
        public double Percent
        {
            get { return _percent; }
            set { SetProperty(ref _percent, value); }
        }

        /// <summary>
        /// Seconds portion of logged time for this editor.
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
        /// Total logged time spent in this editor as seconds.
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
