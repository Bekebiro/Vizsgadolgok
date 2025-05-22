using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace darts
{
    class data
    {
        public bool playerID;
        public string [] types = new string[3];
        public int [] scores = new int[3];
        public data(string line)
        {
            string[] strings = line.Split(';');
            try
            {
                this.playerID = strings[0] == "1";
                for (int i = 0; i < 3; i++)
                {
                    if (strings[i + 1][0] == 'D' || strings[i + 1][0] == 'T')
                    {
                        this.types[i] = strings[i + 1][0].ToString();
                        this.scores[i] = int.Parse(strings[i + 1].Substring(1));
                    }
                    else
                    {
                        this.types[i] = "";
                        this.scores[i] = int.Parse(strings[i + 1]);
                    }
                }
            }
            catch (Exception)
            {
                this.types[0] = "error";
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Változok
            data[] tömb = new data[300];
            int tömbindex = 0;
            List<data> lista = new List<data>();
            #endregion

            #region Beolvasás


            string filename = "dobasok.txt";

            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                data tmp = new data(sr.ReadLine());
                if(tmp.types[0] != "error")
                {
                    lista.Add(tmp);
                    tömb[tömbindex++] = tmp;
                }

            }

            sr.Close();

            #endregion

            #region 2. feladat
            Console.WriteLine("2.feladat");
            Console.WriteLine($"\tKörök száma(tömb): {tömbindex}");
            Console.WriteLine($"\tKörök száma(lista): {lista.Count}");

            #endregion

            #region 3. feladat
            Console.WriteLine("\n3.feladat");

            int bullseye = 0;
            foreach(var item in lista)
            {
                if (item.scores[2] == 25 && item.types[2] == "D")
                {
                    bullseye++;
                }
            }
            Console.WriteLine($"\t3.dobásra Bullseye(lista): {bullseye}");

            bullseye = 0;
            foreach (var item in tömb)
            {
                if(item == null) continue;
                if (item.scores[2] == 25 && item.types[2] == "D") bullseye++;
            }
            Console.WriteLine($"\t3.dobásra Bullseye(tömb): {bullseye}");
            #endregion

            #region 4. feladat
            Console.WriteLine("\n4.feladat");
            Console.Write("\tAdja meg a szektor értékét! Szektor: ");
            string sector = Console.ReadLine();

            int secCount1 = 0;
            int secCount2 = 0;
            int _180PL1 = 0, _180PL2 = 0;

            foreach (var item in lista)
            {
                if (item == null) continue;
                string akarmi = "";
                for (int i = 0; i < 3; i++)
                {
                    if(item.playerID && sector == item.types[i] + item.scores[i].ToString()) secCount1++;
                    else if(!item.playerID & sector == item.types[i] + item.scores[i].ToString()) secCount2++;

                    akarmi += item.types[i] + item.scores[i].ToString();
                }
                if(item.playerID && akarmi == "T20T20T20") _180PL1++;
                else if(!item.playerID && akarmi == "T20T20T20") _180PL2++;
            }
            Console.WriteLine($"\tAz 1. játékos a(z) {sector} szektoros dobásainak száma: {secCount1}");
            Console.WriteLine($"\tAz 2. játékos a(z) {sector} szektoros dobásainak száma: {secCount2}");



            #endregion

            #region 5. feladat
            Console.WriteLine("\n5.feladat");
            Console.WriteLine($"\tAz 1. játkés {_180PL1} db 180-ast dobott.");
            Console.WriteLine($"\tAz 2. játkés {_180PL2} db 180-ast dobott.");


            #endregion

            Console.ReadKey();
        }
    }
}
