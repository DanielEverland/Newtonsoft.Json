using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Newtonsoft.Json
{
    /// <summary>
    /// Used for UMS to create Unity object references
    /// </summary>
    public static class ReferenceHandler
    {
        /// <summary>
        /// Called by the internal JSON serializer when it has to create an object reference
        /// </summary>
        public static Func<object, object> OnCreateReference;

        internal static object GetReference(object value)
        {
            object obj = OnCreateReference?.Invoke(value);

            if (obj == null)
                throw new NullReferenceException();

            return obj;
        }
    }
}
