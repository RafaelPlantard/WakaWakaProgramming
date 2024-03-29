﻿using System;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A code editor used by the user.
    /// </summary>
    [JsonObject]
    public class CodeEditor : BindableBase
    {
        #region Fields

        private DateTime _createdAt;
        private string _digital;
        private string _id;
        private DateTime _modifiedAt;
        private string _name;
        private double _percent;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Time when code editor was created in ISO 8601 format.
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt
        {
            get { return _createdAt; }
            set { SetProperty(ref _createdAt, value); }
        }

        /// <summary>
        /// Total logged time for this editor in digital clock format.
        /// </summary>
        [JsonProperty("digital")]
        public string Digital
        {
            get { return _digital; }
            set { SetProperty(ref _digital, value); }
        }

        /// <summary>
        /// Unique id of code editor.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
        }

        /// <summary>
        /// Time when these editor were last updated in ISO 8601 format
        /// </summary>
        [JsonProperty("modified_at")]
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { SetProperty(ref _modifiedAt, value); }
        }

        /// <summary>
        /// Editor name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Percent of time spent in this editor.
        /// </summary>
        [JsonProperty("percent")]
        public double Percent
        {
            get { return _percent; }
            set { SetProperty(ref _percent, value); }
        }

        /// <summary>
        /// Total logged time spent in this editor as seconds.
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