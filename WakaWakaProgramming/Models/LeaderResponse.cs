using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The response returned when the leader service is requestted.
    /// </summary>
    [JsonObject]
    public class LeaderResponse : BindableBase
    {
        #region Fields

        private ProgrammingLanguageBase _language;
        private string _range;
        private IList<UserRank> _userRanks;

        #endregion

        #region Properties

        /// <summary>
        /// Language of this leaderboard.
        /// </summary>
        [JsonProperty("language")]
        public ProgrammingLanguageBase Language
        {
            get { return _language; }
            set { SetProperty(ref _language, value); }
        }

        /// <summary>
        /// Time range of this leaderboard.
        /// </summary>
        [JsonProperty("range")]
        public string Range
        {
            get { return _range; }
            set { SetProperty(ref _range, value); }
        }

        /// <summary>
        /// The list of users that together composes the rank.
        /// </summary>
        [JsonProperty("data")]
        public IList<UserRank> UserRanks
        {
            get { return _userRanks; }
            set { SetProperty(ref _userRanks, value); }
        }

        #endregion
    }
}
