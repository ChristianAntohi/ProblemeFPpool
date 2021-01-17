using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        //Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
        //x=-b/a
        static double ecuatie(double a, double b)
        {
            return -b / a;
        }

        
        
        static void Main(string[] args)
        {
            Console.WriteLine("introdu a:");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("introdu b:");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + "x" + "+" + b + "=" + 0);
            Console.WriteLine("solutia x=-b/a => x=" +ecuatie(a, b));
            Console.ReadKey();

        }
    }
}
