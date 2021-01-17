using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema11
{
    class Program
    {
        //11.Afisati in ordine inversa cifrele unui numar n. 
      

        static void afisareNumar(int n)
        {
            while (n != 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introdu n: ");
            int n = int.Parse(Console.ReadLine());
            afisareNumar(n);
        }
    }
}
