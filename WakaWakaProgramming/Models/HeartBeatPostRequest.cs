using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The heartbeat that is sent on a post request.
    /// </summary>
    [JsonObject]
    public class HeartBeatPostRequest : BindableBase
    {
        #region Fields

        private string _branch;
        private string _language;
        private int _lines;
        private string _project;
        private IList<string> _dependencies;
        private string _entity;
        private string _type;
        private double _time;

        #endregion

        #region Properties

        /// <summary>
        /// Branch name.
        /// </summary>
        [JsonProperty("branch")]
        public string Branch
        {
            get { return _branch; }
            set { SetProperty(ref _branch, value); }
        }

        /// <summary>
        /// Language name.
        /// </summary>
        [JsonProperty("language")]
        public string Language
        {
            get { return _language; }
            set { SetProperty(ref _language, value); }
        }

        /// <summary>
        /// Total number of lines in the entity (when entity type is file).
        /// </summary>
        [JsonProperty("lines")]
        public int Lines
        {
            get { return _lines; }
            set { SetProperty(ref _lines, value); }
        }

        /// <summary>
        /// Project name.
        /// </summary>
        [JsonProperty("project")]
        public string Project
        {
            get { return _project; }
            set { SetProperty(ref _project, value); }
        }

        /// <summary>
        /// Comma separated list of dependencies detected from entity file.
        /// </summary>
        [JsonProperty("dependencies")]
        public IList<string> Dependencies
        {
            get { return _dependencies; }
            set { SetProperty(ref _dependencies, value); }
        }

        /// <summary>
        /// Entity heartbeat is logging time against, such as an absolute file path or domain.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity
        {
            get { return _entity; }
            set { SetProperty(ref _entity, value); }
        }

        /// <summary>
        /// Type of entity.
        /// </summary>
        /// <remarks>Can be file or domain.</remarks>
        [JsonProperty("type")]
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        /// <summary>
        /// UNIX epoch timestamp.
        /// </summary>
        /// <remarks>Numbers after decimal point are fractions of a second.</remarks>
        [JsonProperty("time")]
        public double Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        #endregion
    }
}