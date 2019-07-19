using System;
using System.Collections.Generic;

namespace GardenMarket.Service.Extension
{
    public static class EnumerableExtention
    {
        internal static IReadOnlyList<T> CustomTake<T>(this IReadOnlyList<T> source, int count)
        {
            if (count > source.Count)
                count = source.Count;
            var result = new T[count];
            for (int i = 0; i < count; i++)
                result[i] = source[i];
            return result;
        }

        public static int FindIndex<T>(this IEnumerable<T> items, Func<T, bool> predicate)
        {
            int retVal = 0;
            foreach (var item in items)
            {
                if (predicate(item)) return retVal;
                retVal++;
            }
            return -1;
        }
    }
}
