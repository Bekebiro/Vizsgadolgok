using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq.Expressions;

namespace ServicePest_javítás
{
    class adatok
    {
        public string szerelo;
        public List<string> gepek = new List<string>();
        public bool[] munka = new bool[7];
        public int minosites;
        public adatok(string sor)
        {
            string[] szet = sor.Split(',');
            int utcso = szet.Length - 1;
            szerelo = szet[0];
            minosites = int.Parse(szet[utcso]);
            for (int i = 1; i < szet.Length - 8; i++)
            {
                gepek.Add(szet[i]);
            }
            int f = 6;
            for (int i = szet.Length - 2; i >= szet.Length - 9; i--)
            {
                if (szet[i] == "X")
                {
                    munka[f] = true;
                }
                f--;

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<adatok> szerelo = new List<adatok>();
            try
            {
                string[] sorok = File.ReadAllLines("Pest.csv", Encoding.UTF8);
                foreach (string sor in sorok)
                {
                    szerelo.Add(new adatok(sor));
                }
                Console.WriteLine("1.feladat:\n A Pest.cvs nevű fálj beolvasása sikeres.");
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException)
                {
                    Console.WriteLine("1.feladat:\nA Pest.cvs nevű fálj beolvasása sikertelen.");
                }
                else if (e is FormatException)
                {
                    Console.WriteLine($"1.feladat:\nHibás adat");
                }
                else
                {
                    Console.WriteLine($"1.feladat:\nEgyéb hiba {e.Message}");
                }
                Console.ReadKey();
                Environment.Exit(0);
            }

            #region 2.feladat

            int legtobbIndex = 0;
            for (int i = 0; i < szerelo.Count; i++)
            {
                if (szerelo[i].gepek.Count > szerelo[legtobbIndex].gepek.Count)
                {
                    legtobbIndex = i;
                }
            }
            Console.Write($"2.feldata:\n A legtöbb ({szerelo[legtobbIndex].gepek.Count}) különböző típusú berendezésekhez értő szerelők neve: ");
            int szDb = 0, vDb = 0, osszeg = 0;
            foreach (var item in szerelo)
            {
                if (item.gepek.Count == szerelo[legtobbIndex].gepek.Count)
                {
                    Console.Write(item.szerelo + ", ");
                }
                if (item.munka[5]) szDb++;
                if (item.munka[6]) vDb++;
                osszeg += item.minosites;
            }
            Console.WriteLine("\b\b");
            #endregion

            #region 3.feladat
            Console.WriteLine($"3. feladat:\n Szombaton {szDb}, vasárnap {vDb} db szerelő áll rendelkezésre");

            #endregion

            #region 4.feladat
            double atlag = (double)osszeg / (double)szerelo.Count;
            int atlagFeletti = 0;
            foreach (var item in szerelo)
            {
                if (item.minosites > atlag) atlagFeletti++;
            }
            Console.WriteLine($"4. feladat:\n A szerelők átlagosan {atlag: #.#} pontot kaptak. A szerelők {(double)atlagFeletti / (double)szerelo.Count * 100: #}%-a az átlagnál magasabb pontszámot kaptak");
            #endregion

            #region 5.feladat
            foreach (var item in szerelo)
            {
                foreach (var item2 in item.gepek)
                {
                    int gazDb = 0;
                    if (item2 == "C" || item2 == "G" || item2 == "K") gazDb++;
                    if (gazDb == 3)
                    {
                        Console.WriteLine(item.szerelo + ", ");
                    }

                }
            }
                Console.WriteLine("\b\b");

                //Console.WriteLine($"5.feladat:\n Mindhárom gázzal működő berendezéshez értő szerelők: {item.szerelo}");

                #endregion

                #region 6.feladat
                Console.Write("6.feladat:\n Adja meg a keresewndő háztartási ezsköz nevének rövidítését:");
                string keszulek = Console.ReadLine();
                if (keszulek != "C" && keszulek != "K" && keszulek != "KG" && keszulek != "P" && keszulek != "H" && keszulek != "G" && keszulek != "MG" && keszulek != "MGT")
                {

                }
                else
                {
                string[] napok = { "Hétfő", "Kedd", "Szerda", "Csütürtök", "Péntek", "Szombat", "Vasárnap" };
                 foreach (var item in szerelo)
                {
                    bool erthozza = false;
                    foreach (var item2 in item.gepek)
                    {
                        if (item2 == keszulek)
                        {
                            erthozza |= true;
                            break;
                        }
                    }
                    if (erthozza)
                    {
                        for (int i = 0; i < item.munka.Length; i++)
                        {
                            if (item.munka[i]) napok[i] = "";
                        }
                    }
                }
                Console.WriteLine("A keresett típushoz a következő napokon nem áll rendelkezésre szerelő: ");
                foreach(var item in napok)
                {
                    if(item != "")Console.Write($"{item}, ");
                }
            }
                #endregion



                Console.ReadKey();
            
        }
    }
}
