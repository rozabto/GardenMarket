using System.Collections.Generic;

namespace GardenMarket.Service.Extension
{
    internal static class EnumerableExtention
    {
        internal static IReadOnlyList<T> CustomTake<T>(this IReadOnlyList<T> source, int count)
        {
            var result = new T[count];
            for (int i = 0; i < count; i++)
                result[i] = source[i];
            return result;
        }
    }
}
