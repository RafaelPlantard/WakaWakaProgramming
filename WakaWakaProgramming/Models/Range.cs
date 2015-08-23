using System;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// 
    /// </summary>
    [JsonObject]
    public class Range : BindableBase
    {
        #region Fields

        private string _date;
        private string _dateHuman;
        private int _end;
        private int _start;
        private string _text;
        private TimeZoneInfo _timezone;

        #endregion

        #region Properties

        /// <summary>
        /// This day as Date string in MONTH/DAY/YEAR format.
        /// </summary>
        [JsonProperty("date")]
        public string Date
        {
            get { return _date; }
            set { SetProperty(ref _date, value); }
        }

        /// <summary>
        /// This day relative to current time.
        /// </summary>
        [JsonProperty("date_human")]
        public string DateHuman
        {
            get { return _dateHuman; }
            set { SetProperty(ref _dateHuman, value); }
        }

        /// <summary>
        /// End of this day as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("end")]
        public int End
        {
            get { return _end; }
            set { SetProperty(ref _end, value); }
        }

        /// <summary>
        /// Start of this day as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("start")]
        public int Start
        {
            get { return _start; }
            set { SetProperty(ref _start, value); }
        }

        /// <summary>
        /// This day in human-readable format.
        /// </summary>
        [JsonProperty("text")]
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        /// <summary>
        /// Timezone used in Olson Country/Region format.
        /// </summary>
        [JsonProperty("timezone")]
        public TimeZoneInfo Timezone
        {
            get { return _timezone; }
            set { SetProperty(ref _timezone, value); }
        }

        #endregion
    }
}