using System.Collections.Generic;

namespace Puffy.Voip
{
    public static class Extensions
    {
        public static void AddIfPresent<T>(this List<T> list, IEnumerable<T> items)
        {
            foreach (var item in items)
                if (item != null)
                    list.Add(item);
        }

        public static string WithLeadingSpace(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;

            return " " + value;
        }
    }
}
