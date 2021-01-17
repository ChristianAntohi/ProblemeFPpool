using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema4
{
    class Program
    {
        //Detreminati daca un an y este an bisect. 
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti anul:");
            int an = int.Parse(Console.ReadLine());
            if (an % 4 == 0)
            {

                Console.WriteLine(an + " este an bisect");
            }
            else
            {
                Console.WriteLine(an + " nu este an bisect");
            }
        }
    }
}
