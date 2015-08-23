using System;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models.Users
{
    /// <summary>
    /// A user of Waka Time.
    /// </summary>
    [JsonObject]
    public class User : BindableBase
    {
        #region Fields

        private DateTime _created;
        private string _email;
        private string _fullName;
        private string _humanReadableWebsite;
        private string _id;
        private bool _isEmailPublic;
        private bool _isLoggedTimePublic;
        private bool _isPhotoPublic;
        private DateTime _lastHeartbeat;
        private string _lastPlugin;
        private string _lastPluginName;
        private string _lastProject;
        private string _location;
        private DateTime _modified;
        private string _photo;
        private string _plan;
        private TimeZoneInfo _timezone;
        private string _username;
        private string _website;

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
        /// Email address of user, if public.
        /// </summary>
        [JsonProperty("email")]
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }

        /// <summary>
        /// Full name of user.
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName
        {
            get { return _fullName; }
            set { SetProperty(ref _fullName, value); }
        }

        /// <summary>
        /// Website of user without url scheme.
        /// </summary>
        [JsonProperty("human_readable_website")]
        public string HumanReadableWebsite
        {
            get { return _humanReadableWebsite; }
            set { SetProperty(ref _humanReadableWebsite, value); }
        }

        /// <summary>
        /// Unique id of user.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        /// <summary>
        /// Whether this user's email should be shown publicly on leader boards.
        /// </summary>
        [JsonProperty("email_public")]
        public bool IsEmailPublic
        {
            get { return _isEmailPublic; }
            set { SetProperty(ref _isEmailPublic, value); }
        }

        /// <summary>
        /// Whether this user's photo should be shown publicly on leader boards.
        /// </summary>
        [JsonProperty("photo_public")]
        public bool IsPhotoPublic
        {
            get { return _isPhotoPublic; }
            set { SetProperty(ref _isPhotoPublic, value); }
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
        /// Location of user.
        /// </summary>
        [JsonProperty("location")]
        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
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

        /// <summary>
        /// The photo url.
        /// </summary>
        [JsonProperty("photo")]
        public string Photo
        {
            get { return _photo; }
            set { SetProperty(ref _photo, value); }
        }

        /// <summary>
        /// Users public username.
        /// </summary>
        [JsonProperty("username")]
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        /// <summary>
        /// Website of user.
        /// </summary>
        [JsonProperty("website")]
        public string Website
        {
            get { return _website; }
            set { SetProperty(ref _website, value); }
        }

        #endregion
    }
}
