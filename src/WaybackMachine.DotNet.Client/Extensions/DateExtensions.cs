using System;
using WaybackMachine.DotNet.Client.Constants;

namespace WaybackMachine.DotNet.Client.Extensions
{
    /// <summary>
    /// Extension methods for working with dates
    /// used in the API.
    /// </summary>
    public static class DateExtensions
    {
        /// <summary>
        /// Simple extension method for converting a
        /// datetime to the string datetime format used
        /// in the Wayback Machine API.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ToWaybackMachineDate(this DateTime date) 
        => date.ToString(FormatConstants.DateFormat);
    }
}