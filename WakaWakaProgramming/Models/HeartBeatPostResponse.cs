using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The heartbase was created on WakaTime Api.
    /// </summary>
    [JsonObject]
    public class HeartBeatPostResponse : BindableBase
    {
        #region Fields

        private string _entity;
        private string _type;
        private double _time;
        private string _id;

        #endregion

        #region Properties

        /// <summary>
        /// Unique id of newly created heartbeat.
        /// </summary>
        [JsonProperty("id")]
        public string Id
        {
            get { return _id; }
            set { SetProperty(ref _id, value); }
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
        /// Type of entity; can be file or domain.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get { return _type; }
            set { SetProperty(ref _type, value); }
        }

        /// <summary>
        /// UNIX epoch timestamp; numbers after decimal point are fractions of a second.
        /// </summary>
        [JsonProperty("time")]
        public double Time
        {
            get { return _time; }
            set { SetProperty(ref _time, value); }
        }

        #endregion
    }
}
