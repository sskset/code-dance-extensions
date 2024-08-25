using System.Collections.Generic;
using System.Linq;

namespace CodeDance.Extensions
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source == null || !source.Any();
        }

        public static bool NotNullOrEmpty<T>(this IEnumerable<T> source)
        {
            return source != null && source.Any();
        }

        public static IEnumerable<T> OrEmpty<T>(this IEnumerable<T> source)
        {
            if (source.IsNullOrEmpty())
            {
                return Enumerable.Empty<T>();
            }

            return source;
        }
    }
}
