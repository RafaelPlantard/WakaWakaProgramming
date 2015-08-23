using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A description of activity of a user in a specific day.
    /// </summary>
    [JsonObject]
    public class DurationResponse : BindableBase
    {
        #region Fields

        private IList<string> _branches;
        private IList<DurationBlock> _durationBlocks;
        private int _end;
        private int _start;
        private string _timezone; 

        #endregion

        #region Properties

        /// <summary>
        /// Branches included in this response.
        /// </summary>
        [JsonProperty("branches")]
        public IList<string> Branches
        {
            get { return _branches; }
            set { SetProperty(ref _branches, value); }
        }

        /// <summary>
        /// A list of duration blocks for each project that the user worked with.
        /// </summary>
        [JsonProperty("data")]
        public IList<DurationBlock> DurationBlocks
        {
            get { return _durationBlocks; }
            set { SetProperty(ref _durationBlocks, value); }
        }

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
        public string Timezone
        {
            get { return _timezone; }
            set { SetProperty(ref _timezone, value); }
        }

        #endregion
    }
}
