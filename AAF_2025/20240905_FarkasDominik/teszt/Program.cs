using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace teszt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int min = 10, max = 1000;
            int number = 0;
            do
            {
                Console.WriteLine("Adjon meg egy számot (10-1000)");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number <= min || number >= max);

            string = 
            Random rnd = new Random();
            int randNum = rnd.Next(10, 1001);

            Console.ReadKey();
        }
    }
}
