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
            //17. Írj programot, mely beolvas egy pozitív egész számot, és megmondja, hogy tökéletes szám-e! 
            //(A tökéletes számok azok, melyek       
            //osztóinak összege egyenlő a szám kétszeresével. Ilyen szám pl. a 6, mert 2*6 = 1 + 2 + 3 + 6.)
            Console.Write("Kérem adjon meg egy egész számot! ");
            int szam = int.Parse(Console.ReadLine());
            int szamlalo = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    szamlalo = szamlalo + i;
                }
            }
            if (szamlalo == szam*2)
            {
                Console.WriteLine($"A felhasználó által megadott szám {szam} tökéletes szám!");
            }
            else
            {
                Console.WriteLine($"A felhasználó által megadott szám {szam} NEM tökéletes szám!");
            }

            //18.Olvassunk be egész számokat egy tömbbe(a darabszámot is kérje be a program),
            //majd írjuk ki a számokat nagyság szerint növekvő sorrendben. (rendezés)
            Console.Write("Kérem adja meg a tömb elemeinek a számát!");
            int elemszam = int.Parse(Console.ReadLine());
            int[] tomb = new int[elemszam];
            Random veletlen = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = veletlen.Next(1,101);
                Console.Write($"{tomb[i]} ");
            }
            //Lineáris rendezés
            //Külsö for ciklus: kiválasszuk a legelső elemet, majd ezt hasonlítjuk az összes többi elemhez!
            Console.WriteLine();
            int csere;
            for (int i = 0;i<tomb.Length-1;i++)
            {
                for(int j = i+1; j < tomb.Length; j++)
                {
                    if (tomb[i] > tomb[j])
                    {
                         csere = tomb[j];
                         tomb[j] = tomb[i];
                         tomb[i] = csere;                      
                    }                  
                }
                if (i < tomb.Length - 2)
                {
                    Console.Write($"{tomb[i]} ");
                }
                else
                {
                    Console.Write($"{tomb[i]} {tomb[i + 1]}");
                }
            }
            /*Console.WriteLine();
            for (int i = 0;i<tomb.Length;i++)
            {
                Console.Write($"{tomb[i]} ");
            }*/
            Console.ReadKey();
        }
    }
}
