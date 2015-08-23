using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The response of User Api request.
    /// </summary>
    [JsonObject]
    public class UserResponse : BindableBase
    {
        #region Fields

        private UserBase _dataUser;

        #endregion

        #region Properties

        /// <summary>
        /// The user data.
        /// </summary>
        [JsonProperty("data")]
        public UserBase DataUser
        {
            get { return _dataUser; }
            set { SetProperty(ref _dataUser, value); }
        }

        #endregion
    }
}