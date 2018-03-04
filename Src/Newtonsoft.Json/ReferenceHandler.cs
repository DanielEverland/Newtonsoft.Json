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

        /// <summary>
        /// Called by the internal JSON serializer to determine whether a type is a reference
        /// </summary>
        public static Func<Type, bool> IsTypeReference;

        /// <summary>
        /// Called by the internal JSON serializer to convert Reference to an object
        /// </summary>
        public static Action<object, Type, Action<object>> AssignObjectValue;
    
        internal static object GetReference(object value)
        {
            object obj = OnCreateReference?.Invoke(value);

            if (obj == null)
                throw new NullReferenceException();

            return obj;
        }
    }
}
