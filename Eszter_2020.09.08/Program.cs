using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._09._08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Írj programot, mely beolvas egy pozitív egész számot, és megmondja, hogy tökéletes szám-e! 
            //(A tökéletes számok azok, melyek       
            //osztóinak összege egyenlő a szám kétszeresével. Ilyen szám pl. a 6, mert 2*6 = 1 + 2 + 3 + 6.)
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam = int.Parse(Console.ReadLine());
            int szamlalo = szam+1;
            for (int i = 2; i <= szam/2; i++)
            {
                if (szam % i == 0)
                {
                    szamlalo = szamlalo + i;
                }
            }

        }
    }
}
