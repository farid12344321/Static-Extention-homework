using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extention_homework.Helphers
{
    internal static class Extention2
    {
        public static double Power(this int num, int power)
        {
            var result = Math.Pow(num, power);

            return result;
        }
    }
}
