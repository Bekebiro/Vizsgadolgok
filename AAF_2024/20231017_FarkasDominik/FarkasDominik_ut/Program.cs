using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FarkasDominik_ut
{
    class data
    {
        public byte hour;
        public byte min;
        public byte sec;
        public int spenttime;
        public bool from = true;

        public data(string dLine)
        {
            string[] strings = dLine.Split(' ');
            this.hour = byte.Parse(strings[0]);
            this.min = byte.Parse(strings[1]);
            this.sec = byte.Parse(strings[2]); 
            this.spenttime = int.Parse(strings[3]);
            if (strings[4] == "A") from = false;
        } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.feladat
            List<data> list = new List<data>();
            StreamReader reader = new StreamReader("forgalom.txt");
            while (!reader.EndOfStream)
            {
                list.Add(new data(reader.ReadLine()));
            }
            reader.Close();
            int lenght = list.Count;
            #endregion

            #region 2.feladat
            /*Console.WriteLine("Adja meg a jármű számát: ");
            string irany = Console.ReadLine();
            int i = irany.Length;*/
            #endregion
            Console.ReadKey();
        }
    }
}
