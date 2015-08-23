using System.Collections.Generic;
using Microsoft.Practices.Prism.Mvvm;
using Newtonsoft.Json;

namespace WakaWakaProgramming.Models
{
    /// <summary>
    /// The summary of a specific user.
    /// </summary>
    [JsonObject]
    public class UserSummary : BindableBase
    {
        #region Fields

        private IList<Editor> _editors;

        #endregion

        #region Properties

        /// <summary>
        /// The list of code editors.
        /// </summary>
        [JsonProperty("editors")]
        public IList<Editor> Editors
        {
            get { return _editors; }
            set { SetProperty(ref _editors, value); }
        }
        

        #endregion
    }
}
