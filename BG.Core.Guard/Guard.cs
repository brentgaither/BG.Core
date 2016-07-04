using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG.Core
{
    /// <summary>
    /// Guards against an object from being null
    /// </summary>

    public static class Guard
    {
        /// <summary>
        /// Throws arguement exception if string is  null or empty
        /// </summary>
        /// <param name="checkString"></param>
        /// <param name="message"></param>
        public static void NotNullOrEmpty(string checkString, string message = "String cannot be null or empty.")
        {
            if (string.IsNullOrEmpty(checkString))
            {
                throw new ArgumentException(message);
            }
            return;
        }
        /// <summary>
        /// Throws argument null exception if object is null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="message"></param>
        public static void NotNull(object obj, string message = "Paramter cannot be null")
        {
            if (obj != null) return;

            throw new ArgumentNullException(null, message);
        }
    }

}
