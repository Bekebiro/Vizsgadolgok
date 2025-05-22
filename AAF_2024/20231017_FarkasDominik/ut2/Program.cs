using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ut2
{
    class data
    {
        public byte hour;
        public byte min;
        public byte sec;
        public int spenttime;
        public string from;

        public data(string dLine)
        {
            try
            {
                string[] strings = dLine.Split(' ');
                this.hour = byte.Parse(strings[0]);
                this.min = byte.Parse(strings[1]);
                this.sec = byte.Parse(strings[2]);
                this.from = strings[3];
            }
            catch(Exception)
            { 
                this.hour = 99;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            StreamReader reader = new StreamReader("forgalom.txt");
            List<data> list = new List<data>();
            int hiba = 0;
            string elsoSor = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                data tmp = new data(reader.ReadLine());
                if (tmp.hour != 99)
                {
                    list.Add(tmp);
                }
                else
                {
                    hiba++;
                }
            }
            reader.Close();
            #endregion

            #region 2.feladat

            int sorszam = 0;
            do
            {
                Console.WriteLine("2.feladat : \n\tAdja meg a jármű sorszámát: ");
                try
                {
                    sorszam = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    sorszam = 0;
                }
            } while (sorszam < 1 || sorszam > list.Count);
            



            #endregion
            #region 3.feladat

            #endregion
            #region 4.feladat

            #endregion
            #region 5.feladat

            #endregion
            Console.ReadKey();
        }
    }
}
