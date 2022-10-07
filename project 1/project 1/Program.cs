/*********************************************************************
* Simple sample C# selection, showing stdin, stdout, static, cetera
*
* Sungmin Choi 
* CS212B
* 9/13/22
*
*********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a Program to compute floor lg lg n! ");
            while (true)
            {
                Console.Write("\nEnter wanted input (n): ");
                double n = double.Parse(Console.ReadLine());
                double lgn = Lg(n);
                double lglgn = Lg(Lg(n));

                if (n <= 1)
                    Console.Write("Invalid input, please input a value larger than 1");
                else
                    Console.WriteLine("lg(lg(({0})) = {1}.", n, lglgn);
            }
        }
        static double Lg(double number)
        {
            double result = 0;
            while (number > 1)
            {
                number /= 2;
                result++;
            }
            return result;
        }
    }
}