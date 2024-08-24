using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    internal static class Extensions
    {
        internal static string ToString<T>(this T[] @this)
        {
            return string.Join(',', @this);
        }
    }
}
