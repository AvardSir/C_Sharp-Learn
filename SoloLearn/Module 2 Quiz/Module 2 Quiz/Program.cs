﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_Quiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Multiple of 3
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++) {
                if (i % 3 != 0) { Console.Write(i); }
                else { Console.Write('*');}
                
            }
        }
    }
}
