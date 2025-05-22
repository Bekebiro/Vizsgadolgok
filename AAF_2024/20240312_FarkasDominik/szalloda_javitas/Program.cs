using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.Permissions;

namespace szalloda_javitas
{
    class adat
    {
        public int sorszam;
        public byte szobaSzam;
        public int erkNap;
        public int tavNap;
        public byte vendegSzam;
        public bool reggeli;
        public string ID;
        public int szobaAr;
        public int ejszakak;

        public adat(string sor, int[,] honapok)
        {
            string[] szet = sor.Split(' ');
            this.sorszam = int.Parse(szet[0]);
            this.szobaSzam = byte.Parse(szet[1]);
            this.erkNap = int.Parse(szet[2]);
            this.tavNap = int.Parse(szet[3]);
            this.vendegSzam = byte.Parse(szet[4]);
            this.reggeli = szet[5] == "1";
            this.ID = szet[6];
            this.ejszakak = this.tavNap - this.erkNap;
        }

    }
    internal class Program
    {

        static int[,] honapok = new int[12, 3];
        static List<string> screenText = new List<string>();
        static List<adat> foglalasok = new List<adat>();


        static int szobaAr(int i)
        {
            int ii = 0;
            int szobaAr = 0;
            while (ii < honapok.GetLength(0) && !(foglalasok[i].erkNap > honapok[ii, 1] && foglalasok[i].erkNap <= honapok[ii, 1] + honapok[ii, 0]))
            {
                ii++;
            }
            if (ii < honapok.GetLength(0))
            {
                szobaAr = honapok[ii, 2];
                if (foglalasok[i].reggeli)
                {
                    szobaAr += (1100 * foglalasok[i].vendegSzam);
                }
                if (foglalasok[i].vendegSzam == 3)
                {
                    szobaAr += 2000;
                }
                
            }
            return szobaAr;

            /*  //for ciklussal
                // void esetén: Console.WriteLine(foglalasok[i].erkNap);
                for (int j = 0; j < honapok.GetLength(0); j++)
            {
                
                if (foglalasok[i].erkNap > honapok[j, 0] && foglalasok[i].erkNap <= honapok[j, 0] + honapok[j, 1])
                {
                    return honapok[j, 2];
                    break;
                }
            }
            return 0;*/



        }
        static void Main(string[] args)
        {
            //Kétnyelvű program
            CultureInfo ci = CultureInfo.InstalledUICulture;
            

            string[] texts;
            try
            {
                texts = File.ReadAllLines(ci.ThreeLetterWindowsLanguageName + ".lng");
            }
            catch(Exception) 
            {
                texts = File.ReadAllLines("eng.lng");
                
            }
            screenText.AddRange(texts);

            //Console.WriteLine("* 3-letter Win32 API Name: {0}", ci.ThreeLetterWindowsLanguageName);
            /*int nyar = int.Parse((string)args[0]);
            int osz = int.Parse((string)args[0]);*/

            //1.feladat
            string[] sorok = File.ReadAllLines("pitypang.txt").Skip(1).ToArray();
            string[] honapSorok = File.ReadAllLines("honapok.txt");
            
            for(int i = 0; i < honapSorok.Length; i = i+4)
            {
                for(int j = 1; j < 4; j++)
                {
                    honapok[i / 4, j  - 1] = int.Parse(honapSorok[i + j]);
                }
            }


            foreach(var item in sorok)
            {
                foglalasok.Add(new adat(item, honapok));
            }
            Console.WriteLine(screenText[0] + foglalasok.Count());

            //2.feladat
            int maxIndex = 0;
            for (int i = 0; i < foglalasok.Count; i++)
            {
                if (foglalasok[i].ejszakak > foglalasok[maxIndex].ejszakak)
                {
                    maxIndex = i;
                }
            }
           

            Console.Write(screenText[1]);
            Console.WriteLine($"{foglalasok[maxIndex].ID} ({foglalasok[maxIndex].erkNap}) - {foglalasok[maxIndex].ejszakak}");

            //3.feladat
            for (int i = 0;i < foglalasok.Count(); i++)
            {
                foglalasok[i].szobaAr = szobaAr(i);
            }

            StreamWriter ki = new StreamWriter("bevetel.txt", false, Encoding.UTF8);
            int osszBevetel = 0;

            foreach(var item in foglalasok)
            {
                ki.WriteLine($"{item.sorszam} : {item.szobaAr * item.ejszakak}");
                osszBevetel += item.szobaAr * item.ejszakak;
            }
            ki.Close();
            Console.WriteLine(screenText[2]);
            Console.WriteLine($"{screenText[2]}: \n\t{osszBevetel.ToString()} {screenText[3]}"); //{osszBevetel: ### ### ###} - ezres tagolás

            //4.feladat

            int evNap = honapok[honapok.GetLength(0)-1, 1] + honapok[honapok.GetLength(0)-1, 0];

            int[,] Napok = new int[evNap, 28];

            foreach(var item in foglalasok)
            {
                for(int i = item.erkNap; i < item.tavNap; i++)
                {
                    Napok[i, 0] += item.vendegSzam;
                    Napok[i, item.szobaSzam] += item.vendegSzam;
                }
            }
            Console.WriteLine(screenText[4]);
            for (int i = 0; i < honapok.GetLength(0); i++)
            {
                int haviNap = 0;
                for(int j = honapok[i, 1]; j < honapok[i, 1] + honapok[i, 0]; j++)
                {
                    haviNap += Napok[j, 0];
                }
                Console.WriteLine($"{i+1}: {haviNap} {screenText[5]}");
            }

            //5.feladat


            Console.ReadKey();
        }
    }
}
