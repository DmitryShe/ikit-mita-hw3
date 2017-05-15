using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public static class Extensions
    {
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0) return true;
            else
                return false;
        }
    }
}
