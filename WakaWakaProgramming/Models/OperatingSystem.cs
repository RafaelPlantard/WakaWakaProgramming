using System;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The operating system that is used by a user.
    /// </summary>
    [JsonObject]
    public class OperatingSystem : BindableBase
    {
        #region Fields

        private DateTime _createdAt;
        private string _id;
        private DateTime _modifiedAt;
        private string _name;
        private int _percent;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Time when OS was created in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        /// <summary>
        /// Unique id of operating system.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        /// <summary>
        /// Time when OS was last modified in ISO 8601 format.
        /// </summary>
        [JsonProperty("modified_at")]
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { SetProperty(ref _modifiedAt, value); }
        }

        /// <summary>
        /// OS name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Percent of time spent in this os.
        /// </summary>
        [JsonProperty("percent")]
        public int Percent
        {
            get { return _percent; }
            set { SetProperty(ref _percent, value); }
        }

        /// <summary>
        /// Total logged time spent in this OS as seconds.
        /// </summary>
        [JsonProperty("total_seconds")]
        public int TotalSeconds
        {
            get { return _totalSeconds; }
            set { SetProperty(ref _totalSeconds, value); }
        }

        #endregion
    }
}
