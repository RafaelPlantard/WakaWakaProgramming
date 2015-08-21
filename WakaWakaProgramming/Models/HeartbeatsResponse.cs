using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The response of a request of heartbeats.
    /// </summary>
    [JsonObject]
    public class HeartbeatsResponse : BindableBase
    {
        #region Properties

        /// <summary>
        /// End of time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("end")]
        public int End { get; set; }

        /// <summary>
        /// A list of heartbeats returned as response of the request.
        /// </summary>
        [JsonProperty("data")]
        public IList<HeartBeat> HeartBeats { get; set; }

        /// <summary>
        /// Start of time range as UNIX epoch timestamp.
        /// </summary>
        [JsonProperty("start")]
        public int Start { get; set; }

        /// <summary>
        /// Timezone used for this request in Olson Country/Region format.
        /// </summary>
        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        #endregion
    }
}
