namespace WakaWakaProgramming.Models.Interfaces
{
    /// <summary>
    /// A prototype of the summary response.
    /// </summary>
    public interface ISummary : IGrandTotal
    {
        #region Properties

        /// <summary>
        /// The percent of a specific activity in comparison of the other inputs.
        /// </summary>
        float Percent { get; set; }

        #endregion
    }
}
