using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Foundation
{
    public static class Extensions
    {
        public static bool In<T>(this T source, params T[] list)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return list.Contains(source);
        }

        public static string Format(this string s, params object[] args)
        {
            return string.Format(s, args);
        }

        public static bool CoinToss(this Random rng)
        {
            return rng.Next(2) == 0;
        }

        public static T OneOf<T>(this Random rng, params T[] things)
        {
            return things[rng.Next(things.Length)];
        }

        public static bool Between<T>(this T actual, T lower, T upper) where T : IComparable<T>
        {
            return actual.CompareTo(lower) >= 0 && actual.CompareTo(upper) < 0;
        }

        public static void AddRange<T, S>(this ICollection<T> list, params S[] values)
            where S : T
        {
            list.AddRange(values);
        }

        public static void Apply<T>(this IEnumerable<T> @enum, Action<T> action)
        {
            foreach (var item in @enum)
                action(item);
        }
    }
}
