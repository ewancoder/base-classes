namespace Lifestyle.Shared
{
    using System;

    /// <summary>
    /// Helper class to test null references.
    /// </summary>
    public static class Guard
    {
        /// <summary>
        /// Tests a value against null reference. Throws NullReferenceException
        /// if the value is null.
        /// </summary>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">Value.</param>
        /// <param name="paramName">Parameter name.</param>
        public static void ThrowIfNull<T>(T value, string paramName)
            where T : class
        {
            if (value == null)
                throw new ArgumentNullException(paramName);
        }
    }
}
