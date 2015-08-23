using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A user of Waka Time.
    /// </summary>
    [JsonObject]
    public class User : BindableBase
    {
        #region Fields

        private string _id;
        private string _email;
        private string _fullName;
        private string _humanReadableWebsite;
        private bool _isEmailPublic;
        private string _location;
        private bool _photoPublic;
        private string _photo;
        private string _username;
        private string _website;

        #endregion

        #region Properties

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
        /// Whether this user's email should be shown publicly on leader boards.
        /// </summary>
        [JsonProperty("email_public")]
        public bool IsEmailPublic
        {
            get { return _isEmailPublic; }
            set { SetProperty(ref _isEmailPublic, value); }
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
        /// Location of user.
        /// </summary>
        [JsonProperty("location")]
        public string Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
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
        /// Whether this user's photo should be shown publicly on leader boards.
        /// </summary>
        [JsonProperty("photo_public")]
        public bool PhotoPublic
        {
            get { return _photoPublic; }
            set { SetProperty(ref _photoPublic, value); }
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
