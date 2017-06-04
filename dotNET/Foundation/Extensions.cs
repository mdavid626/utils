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
    }
}
