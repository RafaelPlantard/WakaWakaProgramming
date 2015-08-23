using System;
using System.IO;
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
        /// <param name="date">Requested day; Durations will be returned from 12am until 11:59pm in user's timezone for this day.</param>
        /// <param name="project">Only show durations for this project.</param>
        /// <param name="branches">Only show durations for these branches; comma separated list of branch names.</param>
        /// <returns>The response for a duration request.</returns>
        [Get("/users/current/durations")]
        Task<DurationResponse> GetDurations([Header("Authorization")] string authorization, DateTime date, string project = null, string branches = null);

        #endregion

        #endregion
    }
}
