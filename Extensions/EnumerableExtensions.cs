using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EntityAPI.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> OrderByProperty<T>(this IEnumerable<T> source, string propertyName, string sortOrder)
        {
            if (string.IsNullOrWhiteSpace(propertyName))
            {
                return source;
            }

            var propertyInfo = typeof(T).GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
            if (propertyInfo == null)
            {
                throw new ArgumentException($"Property '{propertyName}' not found on type '{typeof(T)}'");
            }

            if (sortOrder.Equals("asc", StringComparison.OrdinalIgnoreCase))
            {
                return source.OrderBy(e => propertyInfo.GetValue(e, null));
            }
            else
            {
                return source.OrderByDescending(e => propertyInfo.GetValue(e, null));
            }
        }
    }
}
