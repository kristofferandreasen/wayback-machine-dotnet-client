﻿namespace WaybackMachine.DotNet.Client.Constants
{
    /// <summary>
    /// The base url used to communicate with
    /// the Wayback Machine API.
    /// </summary>
    public static class UrlConstants
    {
        /// <summary>
        /// The base url string for Wayback Machine API.
        /// </summary>
        public const string BaseUrl = "https://archive.org/wayback/available/";

        /// <summary>
        /// The parameter needed to specify the url
        /// to lookup in Wayback Machine.
        /// </summary>
        public const string UrlExtension = "?url=";

        /// <summary>
        /// The timestamp url string used in the Wayback Machine API.
        /// </summary>
        public const string TimeStamp = "&timestamp=";
    }
}
