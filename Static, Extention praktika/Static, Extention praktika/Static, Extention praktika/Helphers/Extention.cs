using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Static__Extention_praktika.Helphers
{
    public static class Extention
    {
        public static int GetNum(this int num)
        {
            return num;
        }

        public static bool CheckString(this string text,string patern)
        {
            return Regex.IsMatch(text,patern);
        }
    }
}
