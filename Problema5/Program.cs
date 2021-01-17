using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problma5
{
    class Program
    {//Problema 5 - Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.

        static void afCifra(int k, int pozitie)
        {
            int i = 1;
            int cifraAfisata = 0;

            while (i <= pozitie)
            {
                cifraAfisata = k % 10;
                k = k / 10;
                i++;
            }
          
            Console.WriteLine("de pe pozitia: " + pozitie + " este:" + cifraAfisata);
        }

        static void Main(string[] args)
        {
            int k = 87878787;
            int cifra = 3;
            Console.WriteLine("Cifra numarului:" + k);
            afCifra(k, cifra);
        }
       

    }
    
}
