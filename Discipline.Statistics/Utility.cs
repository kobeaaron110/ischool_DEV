using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discipline.Statistics
{
    public static class Utility
    {
        public static string ToStr(this int Value)
        {
            return Value > 0 ? ""+Value : string.Empty;
        }
    }
}