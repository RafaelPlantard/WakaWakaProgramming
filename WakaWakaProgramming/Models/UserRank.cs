using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The rank of users by logged time in descending order.
    /// </summary>
    [JsonObject]
    public class UserRank : BindableBase
    {
        #region Fields

        private int _rankPosition;
        private RunningTotal _running;
        private UserBase _rankedUser;

        #endregion

        #region Properties

        /// <summary>
        /// Rank of this leader.
        /// </summary>
        [JsonProperty("rank")]
        public int RankPosition
        {
            get { return _rankPosition; }
            set { SetProperty(ref _rankPosition, value); }
        }

        /// <summary>
        /// The total running of this leader.
        /// </summary>
        [JsonProperty("running_total")]
        public RunningTotal Running
        {
            get { return _running; }
            set { SetProperty(ref _running, value); }
        }

        /// <summary>
        /// The data of the ranked user.
        /// </summary>
        [JsonProperty("user")]
        public UserBase RankedUser
        {
            get { return _rankedUser; }
            set { SetProperty(ref _rankedUser, value); }
        }

        #endregion
    }
}
