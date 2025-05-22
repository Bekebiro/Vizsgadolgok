using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Policy;

namespace lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvüzlöm az eheti lottó húzáson!");
            Console.WriteLine("Adja meg a számait:");

            /*int elso, masodik, harmadik, negyedik, otodik;

         
            Console.Write("Első szám: ");
            elso = Convert.ToInt32(Console.ReadLine());

            Console.Write("Második szám szám: ");
            masodik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Harmadik szám: ");
            harmadik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Negyedik szám: ");
            negyedik = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ötödik szám: ");
            otodik = Convert.ToInt32(Console.ReadLine());

            List<int> list = new List<int>();
            list.Add(elso, masodik, harmadik, negyedik, otodik);*/

            //Számbekérés
            List<int> szamok = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                int szam;
                if (i < 1 && i > 99) ;
                {
                    Console.Write($"A {i + 1}. lottószámod: ");
                    szam = Convert.ToInt32(Console.ReadLine());
                    szamok.Add(szam);
                }
            }
            Console.WriteLine("Az Ön számai: ");
            foreach (int szam in szamok)
            {
                Console.WriteLine(szam);
            }



            //Random lottoszámok

            do
            {
                List<int> lottoszamok = new List<int>();
                Random rnd = new Random();
                //int randomno = rnd.Next(1, 99);
                for (int j = 0; j < 5; j++)
                {
                    lottoszamok.Add((int)j);
                }


                //Metszet
                var union = szamok.Intersect(lottoszamok);

            }

            while (valasz == "Igen" || "igen");
            {

            }

            

            Console.ReadKey();
        }
    }
}
