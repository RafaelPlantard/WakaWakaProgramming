using   Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// A user of Waka Time.
    /// </summary>
    [JsonObject]
    public class User : BindableBase
    {
        #region Properties

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("email_public")]
        public bool EmailPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("human_readable_website")]
        public string HumanReadableWebsite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("photo_public")]
        public bool PhotoPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("website")]
        public string Website { get; set; } 

        #endregion
    }
}
