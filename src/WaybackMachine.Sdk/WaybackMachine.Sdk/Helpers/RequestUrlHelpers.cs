using System;
using WaybackMachine.Sdk.Constants;
using WaybackMachine.Sdk.Extensions;

namespace WaybackMachine.Sdk.Helpers
{
    /// <summary>
    /// Helpers used to construct request
    /// URL's for the API.
    /// </summary>
    public static class RequestUrlHelpers
    {
        /// <summary>
        /// Construct the request url with
        /// the needed parameter for the API.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string ConstructRequest(string url)
        => string.Concat(UrlConstants.UrlExtension, url);

        /// <summary>
        /// Builds the request url used for
        /// getting snapshot close to a specific timestamp.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ConstructRequestWithTimestamp(string url, DateTime date) 
        => string.Concat(url, UrlConstants.TimeStamp, date.ToWaybackMachineDate());
    }
}