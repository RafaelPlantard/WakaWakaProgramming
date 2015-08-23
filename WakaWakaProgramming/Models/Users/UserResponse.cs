using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models.Users
{
    /// <summary>
    /// The response of User Api request.
    /// </summary>
    [JsonObject]
    public class UserResponse : BindableBase
    {
        #region Fields

        private User _dataUser;

        #endregion

        #region Properties

        /// <summary>
        /// The user data.
        /// </summary>
        [JsonProperty("data")]
        public User DataUser
        {
            get { return _dataUser; }
            set { SetProperty(ref _dataUser, value); }
        }

        #endregion
    }
}