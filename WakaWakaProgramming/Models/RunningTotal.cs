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
    /// 
    /// </summary>
    [JsonObject]
    public class RunningTotal : BindableBase
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("daily_average")]
        public int DailyAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("human_readable_daily_average")]
        public string HumanReadableDailyAverage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("human_readable_total")]
        public string HumanReadableTotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("languages")]
        public IList<ProgrammingLanguageBase> Languages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total_seconds")]
        public int TotalSeconds { get; set; }

        #endregion
    }
}
