using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The total of time.
    /// </summary>
    [JsonObject]
    public class GrandTotal : BindableBase
    {
        #region Fields

        private string _digital;
        private int _hours;
        private int _minutes;
        private string _text;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Total logged time in digital clock format.
        /// </summary>
        [JsonProperty("digital")]
        public string Digital
        {
            get { return _digital; }
            set { SetProperty(ref _digital, value); }
        }

        /// <summary>
        /// Hours portion of logged time.
        /// </summary>
        [JsonProperty("hours")]
        public int Hours
        {
            get { return _hours; }
            set { SetProperty(ref _hours, value); }
        }

        /// <summary>
        /// Minutes portion of logged time.
        /// </summary>
        [JsonProperty("minutes")]
        public int Minutes
        {
            get { return _minutes; }
            set { SetProperty(ref _minutes, value); }
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
        /// Total logged time as seconds.
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
