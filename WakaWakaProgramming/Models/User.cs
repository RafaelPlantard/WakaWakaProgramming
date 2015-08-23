using System;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The user returned on Users Api request.
    /// </summary>
    [JsonObject]
    public class User : UserBase
    {
        #region Fields

        private DateTime _created;
        private DateTime _lastHeartbeat;
        private string _lastPlugin;
        private string _lastPluginName;
        private string _lastProject;
        private bool _isLoggedTimePublic;
        private DateTime _modified;
        private string _plan;
        private TimeZoneInfo _timezone;

        #endregion

        #region Properties

        /// <summary>
        /// Time when user was created in ISO 8601 format.
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created
        {
            get { return _created; }
            set { SetProperty(ref _created, value); }
        }

        /// <summary>
        /// Time of most recent heartbeat logged by this user.
        /// </summary>
        [JsonProperty("last_heartbeat")]
        public DateTime LastHeartbeat
        {
            get { return _lastHeartbeat; }
            set { SetProperty(ref _lastHeartbeat, value); }
        }

        /// <summary>
        /// Last plugin used by this user.
        /// </summary>
        [JsonProperty("last_plugin")]
        public string LastPlugin
        {
            get { return _lastPlugin; }
            set { SetProperty(ref _lastPlugin, value); }
        }

        /// <summary>
        /// Last plugin name used by this user
        /// </summary>
        [JsonProperty("last_plugin_name")]
        public string LastPluginName
        {
            get { return _lastPluginName; }
            set { SetProperty(ref _lastPluginName, value); }
        }

        /// <summary>
        /// Name of last project logged by this user.
        /// </summary>
        [JsonProperty("last_project")]
        public string LastProject
        {
            get { return _lastProject; }
            set { SetProperty(ref _lastProject, value); }
        }

        /// <summary>
        /// Whether this user's logged time should be shown publicly on leader boards.
        /// </summary>
        [JsonProperty("logged_time_public")]
        public bool IsLoggedTimePublic
        {
            get { return _isLoggedTimePublic; }
            set { SetProperty(ref _isLoggedTimePublic, value); }
        }

        /// <summary>
        /// Time when user was last modified in ISO 8601 format.
        /// </summary>
        [JsonProperty("modified")]
        public DateTime Modified
        {
            get { return _modified; }
            set { SetProperty(ref _modified, value); }
        }

        /// <summary>
        /// Users subscription plan.
        /// </summary>
        [JsonProperty("plan")]
        public string Plan
        {
            get { return _plan; }
            set { SetProperty(ref _plan, value); }
        }

        /// <summary>
        /// User's timezone in Olson Country/Region format.
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
