using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Program
    {
        static void wait(string text)
        {
            Console.WriteLine(text);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            //akasaks

            /*ékméklsca
             * 
             */
            #region feladat1
            //Kérjen be egy nevet
            string yourName = null ;
            
            do
            {
                Console.Write("Kérema a nevét: ");
                yourName = Console.ReadLine();
            } while (yourName == "");
            Console.WriteLine("Helló " + yourName);
            wait("Billentyűre tovább...");
            #endregion

            #region feladat2
            //Kérjen be egy nevet
            int yourAge = 0;

            do
            {
                Console.Write("Kérem a korát: ");
                yourAge = Convert.ToInt32(Console.ReadLine()); // Convert.int.Parse(Console.ReadLine());
            } while (yourAge == 0);
            Console.WriteLine("Az Ön életkor {0} év.", yourAge.ToString());
            Console.WriteLine("Az Ön neve {0}, életkora {1} év.", yourName, yourAge.ToString());
            #endregion

            /* #region feladat2
             Console.WriteLine("Hello");
             Console.WriteLine("Dominik");
             Console.ReadKey();
             #endregion
            */
            wait("Billentyűre kilépés...");
        }
    }
}
