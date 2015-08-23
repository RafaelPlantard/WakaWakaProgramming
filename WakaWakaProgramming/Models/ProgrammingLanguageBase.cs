using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The basic encapsulation of a programming language.
    /// </summary>
    [JsonObject]
    public class ProgrammingLanguageBase : BindableBase
    {
        #region Fields

        private string _name;
        private int _totalSeconds;

        #endregion

        #region Properties

        /// <summary>
        /// Language name.
        /// </summary>
        [JsonProperty("name")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        /// <summary>
        /// Total seconds user has logged in this language.
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