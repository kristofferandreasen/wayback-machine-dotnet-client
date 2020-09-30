namespace WaybackMachine.Sdk.Extensions
{
    /// <summary>
    /// Generic extension methods for working with 
    /// objects used in the API.
    /// </summary>
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks whether a specific property
        /// exists on an object.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static bool HasProperty(this object obj, string propertyName) 
        => obj.GetType().GetProperty(propertyName) != null;
    }
}