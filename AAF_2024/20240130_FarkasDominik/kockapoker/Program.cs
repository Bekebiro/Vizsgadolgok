using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace kockapoker
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            // Játkésok száma
            Console.WriteLine("Üdvözöljük a kockapóker játékban!");
            Console.WriteLine("Adja meg a játékosok számát: ");
            int jatekosSzam = 0;
            do
            {
                int AskIn = Convert.ToInt32(Console.ReadLine());
                if (AskIn > 1 && AskIn <= 10)
                {
                    jatekosSzam += AskIn;
                }
                else
                {
                    Console.WriteLine("A szám nem megfelelő, adjon új számot");
                }
            }
            while (jatekosSzam < 2 || jatekosSzam > 10);



            // Kockával való sobás és eredmény eltárolása

            List<int> dobottSzamok = new List<int>();
            
            for (int j = 0; j < jatekosSzam; j++)
            {
                Random rnd = new Random();
                for (int i = 1; i <= 5; i++)
                {
                    int szam = rnd.Next(1, 7);
                    Console.WriteLine(szam);
                }
            }





            //Console.WriteLine($"A {j+1}. játékos számai: ");
            /*foreach (int i in dobottSzamok)
            {
                Console.WriteLine(i);
            }
            }*/
            //Kombók




































            Console.ReadKey();
        }

    }
}
