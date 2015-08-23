using System;
using System.Collections.Generic;
using Windows.Globalization;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The stats of a user for a specific given time range.
    /// </summary>
    [JsonObject]
    public class StatsResponse : BindableBase
    {
        #region Fields

        private DateTime _createdAt;
        private IList<CodeEditor> _editors;
        private int _end;
        private string _humanReadableDailyAverage;
        private string _humanReadableTotal;
        private string _id;
        private bool _isUpToDate;
        private IList<Language> _languages;
        private DateTime _modifiedAt;
        private IList<OperatingSystem> _operatingSystems;
        private string _project;
        private IList<Project> _projects;
        private string _range;
        private int _start;
        private string _status;
        private int _timeout;
        private string _timezone;
        private int _totalSeconds;
        private string _userId;
        private string _username;
        private bool _writesOnly;

        #endregion

        #region Properties

        /// <summary>
        /// Time when these stats were created in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        /// <summary>
        /// The code editors that the user had used.
        /// </summary>
        [JsonProperty("editors")]
        public IList<CodeEditor> Editors
        {
            get { return _editors; }
            set { SetProperty(ref _editors, value); }
        }

        /// <summary>
        /// End of this time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("end")]
        public int End
        {
            get { return _end; }
            set { SetProperty(ref _end, value); }
        }

        /// <summary>
        /// Daily average for this user as human readable string.
        /// </summary>
        [JsonProperty("human_readable_daily_average")]
        public string HumanReadableDailyAverage
        {
            get { return _humanReadableDailyAverage; }
            set { SetProperty(ref _humanReadableDailyAverage, value); }
        }

        /// <summary>
        /// Total logged time for this user as human readable string.
        /// </summary>
        [JsonProperty("human_readable_total")]
        public string HumanReadableTotal
        {
            get { return _humanReadableTotal; }
            set { SetProperty(ref _humanReadableTotal, value); }
        }

        /// <summary>
        /// Unique id of the user, based in a GUID. 
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        /// <summary>
        /// A boolean that indicates whether the stats is up to date.
        /// </summary>
        [JsonProperty("is_up_to_date")]
        public bool IsUpToDate
        {
            get { return _isUpToDate; }
            set { SetProperty(ref _isUpToDate, value); }
        }

        /// <summary>
        /// The programming languages that the user used in the time range.
        /// </summary>
        [JsonProperty("languages")]
        public IList<Language> Languages
        {
            get { return _languages; }
            set { SetProperty(ref _languages, value); }
        }

        /// <summary>
        /// Time when these stats were last updated in ISO 8601 format.
        /// </summary>
        [JsonProperty("modified_at")]
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { SetProperty(ref _modifiedAt, value); }
        }

        /// <summary>
        /// The list of operating systems that the user has used.
        /// </summary>
        [JsonProperty("operating_systems")]
        public IList<OperatingSystem> OperatingSystems
        {
            get { return _operatingSystems; }
            set { SetProperty(ref _operatingSystems, value); }
        }

        /// <summary>
        /// Represents the name of a specific project.
        /// </summary>
        [JsonProperty("project")]
        public string Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        /// <summary>
        /// The list of projects that the user has been modified.
        /// </summary>
        [JsonProperty("projects")]
        public IList<Project> Projects
        {
            get { return _projects; }
            set { SetProperty(ref _projects, value); }
        }

        /// <summary>
        /// Time range of these stats.
        /// </summary>
        [JsonProperty("range")]
        public string Range
        {
            get { return _range; }
            set { SetProperty(ref _range, value); }
        }

        /// <summary>
        /// Start of this time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("start")]
        public int Start
        {
            get { return _start; }
            set { SetProperty(ref _start, value); }
        }

        /// <summary>
        /// Status of these stats in the cache.
        /// </summary>
        [JsonProperty("status")]
        public string Status
        {
            get { return _status; }
            set { SetProperty(ref _status, value); }
        }

        /// <summary>
        /// Value of the user's timeout setting in minutes.
        /// </summary>
        [JsonProperty("timeout")]
        public int Timeout
        {
            get { return _timeout; }
            set { SetProperty(ref _timeout, value); }
        }

        /// <summary>
        /// Timezone used in Olson Country/Region format.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone
        {
            get { return _timezone; }
            set { SetProperty(ref _timezone, value); }
        }

        /// <summary>
        /// Total logged time as seconds for the given range of time.
        /// </summary>
        [JsonProperty("total_seconds")]
        public int TotalSeconds
        {
            get { return _totalSeconds; }
            set { SetProperty(ref _totalSeconds, value); }
        }

        /// <summary>
        /// Unique id of this user.
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId
        {
            get { return _userId; }
            set { SetProperty(ref _userId, value); }
        }

        /// <summary>
        /// Public username for this user.
        /// </summary>
        [JsonProperty("username")]
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        /// <summary>
        /// Status of the user's writes_only setting.
        /// </summary>
        [JsonProperty("writes_only")]
        public bool WritesOnly
        {
            get { return _writesOnly; }
            set { SetProperty(ref _writesOnly, value); }
        }

        #endregion

    }
}
