﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extention_praktika
{
    internal class Car
    {
        public static int Speed { get; set; } = 500;

        static Car()
        {
            Console.WriteLine("Static conusturuktor");
        }
        public Car()
        {
            Console.WriteLine("Conusturuktor");
        }
       
    }

  
}
