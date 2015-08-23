using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The summary of a user.
    /// </summary>
    [JsonObject]
    public class SummaryResponse : BindableBase
    {
        #region Fields

        private int _end;
        private int _start;
        private UserSummary _userSummary;

        #endregion

        #region Properties

        /// <summary>
        /// The user summary.
        /// </summary>
        [JsonProperty("data")]
        public UserSummary UserSummary
        {
            get { return _userSummary; }
            set { SetProperty(ref _userSummary, value); }
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

        #endregion
    }
}
