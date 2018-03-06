using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtonsoft.Json.Utilities
{
    /// <summary>
    /// Utilities used for Unity interaction
    /// </summary>
    public static class UnityUtilities
    {
        /// <summary>
        /// Checks whether an object is null
        /// </summary>
        public static bool IsNull(object obj)
        {
            if (obj == null)
                return true;

            if (obj.ToString() == "null")
                return true;

            return false;
        }
    }
}
