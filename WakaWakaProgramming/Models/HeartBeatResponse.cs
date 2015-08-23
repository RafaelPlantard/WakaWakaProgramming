using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The response of a request of heartbeats.
    /// </summary>
    [JsonObject]
    public class HeartBeatResponse : BindableBase
    {
        #region Fields

        private int _end;
        private IList<HeartBeat> _heartBeats;
        private int _start;
        private TimeZoneInfo _timezone;

        #endregion

        #region Properties

        /// <summary>
        /// End of time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("end")]
        public int End
        {
            get { return _end; }
            set { SetProperty(ref _end, value); }
        }

        /// <summary>
        /// A list of heartbeats returned as response of the request.
        /// </summary>
        [JsonProperty("data")]
        public IList<HeartBeat> HeartBeats
        {
            get { return _heartBeats; }
            set { SetProperty(ref _heartBeats, value); }
        }

        /// <summary>
        /// Start of time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("start")]
        public int Start
        {
            get { return _start; }
            set { SetProperty(ref _start, value); }
        }

        /// <summary>
        /// Timezone used for this request in Olson Country/Region format.
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
