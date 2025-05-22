using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml.Schema;

namespace ServicePest
{
    class adatok
    {
        public string azonosito;
        public List<string> gepek = new List<string>();
        public List<bool> napok = new List<bool>();
        public byte ertekeles;

        public adatok(string sor) 
        {
            string[] sorok = sor.Split(',');
            this.azonosito = sorok[0];
            this.gepek = new List<string>();
            this.napok = new List<bool>();
            this.ertekeles = byte.Parse(sorok[sorok.Length-1]);

            int count = sorok.Length - 2;
            for(int i = 1; i < count + 1; i++)
            {
                if( i < count - 6)
                {
                    this.gepek.Add(sorok[i]);
                }
                else
                {
                    this.napok.Add(sorok[i] == "X");
                }
            }

  
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<adatok> list = new List<adatok>();
                StreamReader reader = new StreamReader("Pest.csv");
                while (!reader.EndOfStream)
                {
                    list.Add(new adatok(reader.ReadLine()));
                }
                reader.Close();
                Console.WriteLine($"A {list.Count} pesti szerelő adatainak beolvasása sikeresen megtörtént");

                /*for(int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine($"{list[i].azonosito} {string.Join(", ", list[i].gepek)} {string.Join(", ", list[i].napok)} {string.Join(", ", list[i].ertekeles)} ");
                }*/

                //2.feladat

                int max = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].gepek.Count > i)
                    {
                        max += i;
                    }
                    if (list[i].gepek.Count == max)
                    {
                        Console.WriteLine($"A legtöbb ({max} db) különböző típusú berendezéshez értő szerelők azonosítója: {string.Join(", ",list[i].azonosito)}");
                    }
                }

                //3.feladat
                int szombat = 0;
                int vasarnap = 0;

                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].napok[list.Count-1] == false)
                    {
                        szombat += 1;
                    }

                    if (list[i].napok[list.Count-2] == false)
                    {
                        vasarnap += 1;
                    }
                }
                Console.WriteLine($"Szombatonként {szombat} szerelő, vasárnaponként {vasarnap} szerelő áll rendelkezésre.");

                //4.feladat
                double ossz = 0;
                double atlag = 0;
                int atlagFeletti = 0;
                int szazalek = 0;
                for(int i = 0;i < list.Count; i++)
                {
                    ossz += list[i].ertekeles;
                    atlag = Math.Round(ossz / list.Count, 1);
                    if(atlag > list[i].ertekeles)
                    {
                        atlagFeletti += 1;
                        szazalek = (atlagFeletti / list.Count) *100;
                    }
                }

                Console.WriteLine($"A szerelők átlagosan {atlag} pontot kaptak. A szerelők {szazalek}%-a az átlagnál magasabb pontszámot kapott.");

            } catch (Exception) {
                Console.WriteLine("A fájl beolvasása sikertelen");
            }

            


            Console.ReadKey();
        }
    }
}
