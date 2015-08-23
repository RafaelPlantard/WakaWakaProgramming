using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The total of work that was done.
    /// </summary>
    [JsonObject]
    public class RunningTotal : BindableBase
    {
        #region Fields

        private int _dailyAverage;
        private string _humanReadableTotal;
        private IList<ProgrammingLanguageBase> _languages;
        private int _totalSeconds;
        private string _humanReadableDailyAverage;

        #endregion

        #region Properties

        /// <summary>
        /// Daily average for this user as seconds.
        /// </summary>
        [JsonProperty("daily_average")]
        public int DailyAverage
        {
            get { return _dailyAverage; }
            set { SetProperty(ref _dailyAverage, value); }
        }

        /// <summary>
        /// Daily average for this user as human readable string.
        /// </summary>
        [JsonProperty("human_readable_daily_average")]
        public string HumanReadableDailyAverage
        {
            get { return _humanReadableDailyAverage; }
            set { SetProperty(ref _humanReadableDailyAverage, value); }
        }

        /// <summary>
        /// Total logged time for this user as human readable string.
        /// </summary>
        [JsonProperty("human_readable_total")]
        public string HumanReadableTotal
        {
            get { return _humanReadableTotal; }
            set { SetProperty(ref _humanReadableTotal, value); }
        }

        /// <summary>
        /// The list of the languages was used in a specific range of time.
        /// </summary>
        [JsonProperty("languages")]
        public IList<ProgrammingLanguageBase> Languages
        {
            get { return _languages; }
            set { SetProperty(ref _languages, value); }
        }

        /// <summary>
        /// Total logged time for this user as seconds.
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
