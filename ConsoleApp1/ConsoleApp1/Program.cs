﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ameba();
        }
        static void ameba()
        {
            double x = 2;
            double sum = 0;
            for (double i = 1; i <= 10; i++)
            {
                sum += Math.Pow(x, i) / (x * i);
            }
            Console.WriteLine(sum);
        }
    }
}
