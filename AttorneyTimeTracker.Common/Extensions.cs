using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttorneyTimeTracker.Common
{
    public static class Extensions
    {
        public static string NullToEmpty(this string input)
        {
            return input ?? string.Empty;
        }
    }
}
