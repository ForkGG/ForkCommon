using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectAveryCommon.ExtensionMethods
{
    public static class EnumExtensions
    {
        // Get a list of all values of enum T
        public static IEnumerable<T> GetValues<T>() where T : Enum
        {
            if (!typeof(T).IsEnum)
            {
                return new List<T>();
            }

            return Enum.GetValues(typeof(T)).Cast<T>();
        }
    }
}