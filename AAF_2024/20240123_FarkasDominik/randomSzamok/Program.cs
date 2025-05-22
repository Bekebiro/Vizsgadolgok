using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomSzamok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1000 db szám 0 - 100-ig
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0 ; i <= 999; i++)
            {
                int szam = rnd.Next(0, 1000);
                list.Add(szam);
            }
            /*foreach (int szam in list)
            {
                Console.WriteLine(szam);
            }*/
           
            List<int> paros = new List<int>();
            int parosSzam = 0;
            int paratlanSzam = 0;
            List<int> paratlan = new List<int>();

            for(int i = 0; i<= 999; i++)
            {
                if (list[i] % 2 == 0)
                {
                    paros.Add(i);
                    parosSzam++;
                }
                else
                {
                    paratlan.Add(i);
                    paratlanSzam++;
                }
            }
            Console.WriteLine($"Páros számok: {parosSzam} db");
            Console.WriteLine($"Páratlan számok: {paratlanSzam} db");

           
            List<int> prim = new List<int>();  
            int primSzam = 0;
            
            
            for (int i = 0; i <= 999; i++)
            {
                if (list[i] % 2 != 0 && list[i] % 3 != 0 && list[i] % 5 != 0 && list[i] % 7 != 0)
                {
                    list.Add(i);
                    primSzam++;
                }
            }
            Console.WriteLine($"Páros számok: {primSzam} db");

            List<int>atlagFelett = new List<int>();
            List<int>atlagAlatt = new List<int>();
            double atlag = list.Sum() / list.Count;
            Console.WriteLine($"A számok átlaga: {atlag}");

            for (int i = 0; i<= 999; i++)
            {
              
                if (list[i] > atlag)
                {
                    atlagFelett.Add(i);
                }
                else
                {
                    atlagAlatt.Add(i);
                }
                Console.WriteLine(atlagFelett.Count);
                Console.WriteLine(atlagAlatt.Count);
                

            }






            Console.ReadKey();
        }
    }
}
