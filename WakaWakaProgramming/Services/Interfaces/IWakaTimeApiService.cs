using System;
using System.Threading.Tasks;
using Refit;
using WakaWakaProgramming.Models;

namespace WakaWakaProgramming.Services.Interfaces
{
    /// <summary>
    /// The prototype of the API service provided by Waka Time.
    /// </summary>
    public interface IWakaTimeApiService
    {
        #region Methods

        #region Durations

        /// <summary>
        /// A user's logged time for the given day as an array of duration blocks.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="date">Requested day.</param>
        /// <param name="project">Only show durations for this project.</param>
        /// <param name="branches">Only show durations for these branches; comma separated list of branch names.</param>
        /// <returns>Durations will be returned from 12am until 11:59pm in user's timezone for this day.</returns>
        [Get("/users/current/durations")]
        Task<DurationResponse> GetDurations([Header("Authorization")] string authorization, DateTime date, string project = default(string), string branches = default(string));



        #endregion

        #region Heartbeats

        /// <summary>
        /// A user's heartbeats sent from plugins for the given day as an array.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="date">Requested day.</param>
        /// <returns>Heartbeats will be returned from 12am until 11:59pm in user's timezone for this day.</returns>
        [Get("/users/current/heartbeats")]
        Task<HeartBeatResponse> GetHeartbeats([Header("Authorization")] string authorization, DateTime date);

        /// <summary>
        /// Creates a heartbeat representing activity for a user.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="heartbeat">The heartbeat to be added.</param>
        /// <returns>The heartbeat created.</returns>
        [Post("/users/current/heartbeats")]
        Task<HeartBeatPostResponse> PostHeartbeats([Header("Authorization")] string authorization, [Body] HeartBeatPostRequest heartbeat);

        #endregion

        #region Leaders

        /// <summary>
        /// List of users ranked by logged time in descending order. Same as the public leaderboards.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="language">Filter leaders by a specific language.</param>
        /// <returns>List of users ranked by logged time.</returns>
        [Get("/leaders")]
        Task<LeaderResponse> GetLeaders([Header("Authorization")] string authorization, string language = default(string));

        #endregion

        #region Stats

        /// <summary>
        /// A user's logged time for the given time range.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="range">The range can be one of last_7_days, last_30_days, last_6_months, last_year, or all_time.</param>
        /// <param name="timeout">The timeout value used to calculate these stats. Defaults the the user's timeout value.</param>
        /// <param name="iswritesOnly">The writes_only value used to calculate these stats. Defaults to the user's writes_only setting.</param>
        /// <param name="project">Show more detailed stats limited to this project.</param>
        /// <returns></returns>
        [Get("/users/current/stats/{range}")]
        Task<StatsResponse> GetStats([Header("Authorization")] string authorization, string range, int timeout = default(int), [AliasAs("writes_only")] bool iswritesOnly = false, string project = default(string));

        #endregion

        #region Summaries

        /// <summary>
        /// A user's logged time for the given time range as an array of summaries segmented by day.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <param name="start">Start date of the time range.</param>
        /// <param name="end">End date of the time range.</param>
        /// <param name="project">Only show time logged to this project.</param>
        /// <param name="branches">Only show logged time for these branches; comma separated list of branch names.</param>
        /// <returns>The summary of users for the given time range.</returns>
        [Get("/users/current/summaries")]
        Task<SummaryResponse> GetSummaries([Header("Authorization")] string authorization, DateTime start, DateTime end, string project = default(string), string branches = default(string));

        #endregion

        #region Users

        /// <summary>
        /// A single user.
        /// </summary>
        /// <param name="authorization">The authorization based on the api-key enconded to base64.</param>
        /// <returns>Returns a single user.</returns>
        Task<UserResponse> GetUsers([Header("Authorization")] string authorization);

        #endregion

        #endregion
    }
}
