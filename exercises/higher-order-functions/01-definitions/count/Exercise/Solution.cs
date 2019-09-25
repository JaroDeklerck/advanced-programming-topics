using System;
using System.Collections.Generic;

namespace Exercise.Solution
{
    public static class IEnumerableExtensions
    {
        public static int Count<T>(this IEnumerable<T> xs, Func<T, bool> predicate)
        {
            int count = 0;

            foreach (var x in xs)
            {
                if (predicate(x))
                {
                    ++count;
                }
            }

            return count;
        }
    }
}
