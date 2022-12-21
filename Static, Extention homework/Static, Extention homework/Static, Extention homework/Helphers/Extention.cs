using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extention_homework.Helphers
{
    public static class Extention
    {
        public static int Faktorial(this int num)

        {
       
            int multiple = 1;
            for (int i = 1; i <= num; i++)
            {
                multiple *= i;
            }
            return multiple;
        }



     
    }

   


}
