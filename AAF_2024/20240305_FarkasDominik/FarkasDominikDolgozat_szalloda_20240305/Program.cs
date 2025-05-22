using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace FarkasDominikDolgozat_szalloda_20240305
{
   internal class data
    {
        public int sorszam;
        public byte szobaszam;
        public int erkNap;
        public int tavNap;
        public int vendegSzam;
        public bool reggeli = false;
        public string nev;
        public data(string line) 
        {
            string[] strings = line.Split(' ');
            this.sorszam = int.Parse(strings[0]);
            this.szobaszam = byte.Parse(strings[1]);
            this.erkNap = int.Parse(strings[2]);
            this.tavNap = int.Parse(strings[3]);
            this.vendegSzam = int.Parse(strings[4]);
            this.nev = strings[6];

            if (strings[5] == "1") this.reggeli = true;
            
        }

    }

    internal class honapok
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.feladat
            List<data> list = new List<data>();
            StreamReader reader = new StreamReader("pitypang.txt");
            string firstLine = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                list.Add(new data(reader.ReadLine()));
            }
            reader.Close();
            int lenght = list.Count;
            //Console.WriteLine(lenght);
            #endregion

            #region 2.feladat

            int legtovabb = 0;
            for (int i = 0; i < list.Count ; i++)
            {
                if (list[i].tavNap - list[i].erkNap > legtovabb)
                {
                    legtovabb = list[i].tavNap - list[i].erkNap;
                    Console.WriteLine($"2: feladat: {list[i].nev} - ({list[i].erkNap}) - {legtovabb}");
                }
                
            }


           
            
            #endregion

            #region 3.feladat
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i].erkNap >= 120)
                {
                    int fizetes = ((list[i].tavNap - list[i].erkNap) * 9000) + ((list[i].vendegSzam - 2) * 2000);
                    if (list[i].reggeli == true)
                    {
                        fizetes += (list[i].vendegSzam - 2) * 1100;
                    }
                    Console.WriteLine($"{list[i].sorszam}:{fizetes}");
                }
            }

            /*int szallodaBev = 0;
            for(int i = 0; ; i++)
            {

            }*/




            #endregion

            #region 4.feladat

            #endregion

            #region 5.feladat

            #endregion


            Console.ReadKey();
        }
    }
}
