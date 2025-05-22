using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace barlang
{
    public class Barlang
    {
        public int azon { get; private set; }
        public string nev { get; private set; }
        public string telepules { get; private set; }
        public string vedettseg { get; set; }
        private int H = 0;
        private int M = 0;
        public int hossz {
            get
            {
                return H;
            }
            set
            {
                if (H <= value || value == 0)
                {
                    H = value;
                }
            }
        }
        public int melyseg {
            get
            {
                return M;
            }
            set
            {
                if(M <= value)
                {
                    M = value;
                }
            }
        }

        public Barlang(string line)
        {
            try
            {
                string[] strings = line.Split(';');
                azon = int.Parse(strings[0]);
                nev = strings[1];
                hossz = int.Parse(strings[2]);
                melyseg = int.Parse(strings[3]);
                telepules = strings[4];
                vedettseg = strings[5];
            }
            catch (Exception)
            {
                hossz = 0;
            }
        }

        public override string ToString()
        {
            return $"Azon: {azon}\nNév: {nev}Hossz: {hossz}\nMélység: {melyseg}\nTelepülés: {telepules}\nVédettség: {vedettseg}";
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Barlang a = new Barlang("1;Név;580;50;település;védettség");
            Console.WriteLine($"Azon: {a.azon}\nNén: {a.nev}Hossz: {a.hossz}\nMélység: {a.melyseg}\nTelepülés: {a.telepules}\nVédettség: {a.vedettseg}");
            Console.WriteLine();
            Console.WriteLine(a.ToString());*/

            StreamReader reader = new StreamReader("..\\..\\..\\barlangok.txt", Encoding.UTF8);

            while (!reader.EndOfStream)
            {
                Barlang a = new Barlang(reader.ReadLine());
                if (a.hossz == 0) continue;
                /*Console.WriteLine(a.ToString());
                Console.WriteLine();*/
            }

            List<Barlang> barlangok = new List<Barlang>();
            while (!reader.EndOfStream)
            {
                Barlang tmp = new Barlang(reader.ToString());
                if(tmp.hossz != 0) barlangok.Add(tmp);
            }

            //2.feladat
            Console.WriteLine($"2. feladat: Barlangok száma: {barlangok.Count}");

            //3.feladat






            reader.Close();
            Console.ReadKey();
        }
    }
}
