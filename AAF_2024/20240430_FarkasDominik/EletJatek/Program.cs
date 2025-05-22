using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EletJatek
{
    public class Eletjatekszimulator
    {
        private int[,] Matrix;
        private int OszlopokSzama;
        private int SorokSzama;

        public  Eletjatekszimulator(int oszlopokSzama, int sorokSzama)
        {
            this.SorokSzama = sorokSzama + 2;
            this.OszlopokSzama = oszlopokSzama + 2; 
            Matrix = new int[this.OszlopokSzama, this.SorokSzama];

            
            Random rnd = new Random();
            for (int i = 0; i < this.OszlopokSzama; i++)
            {
                for (int j = 0; j < this.SorokSzama; j++)
                {
                    Matrix[i, j] = rnd.Next(0,2);
                }
            }
        }
        private void Megjelenit()
        {
            Console.Clear();
            for(int i = 0; i < this.OszlopokSzama; i++)
            {
                for(int j = 0; j < this.SorokSzama; j++)
                {
                    if(i == 0 || i == this.OszlopokSzama - 1 || j == 0 || j == this.SorokSzama - 1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (this.Matrix[i, j] == 1)
                        {
                            Console.Write("S");
                        }
                        else { Console.Write(" "); }
                    }
                }
                Console.WriteLine();
            }
        }

        public void KovetkezoAllapot()
        {
            for(int i = 1; i < this.OszlopokSzama; i++)
            {
                for (int j = 1; j < this.SorokSzama; j++)
                {
                    if (i == 0 || i == this.OszlopokSzama - 1 || j == 0 || j == this.SorokSzama - 1) continue;
                    else 
                    { 
                        //szomszédok megszámolása
                        int szomszed = 0;
                        for (int k = -1; k < 2; k++)
                        {
                            for (int l = -1; l < 2; l++)
                            {
                                if (k == 0 && l == 0)
                                {
                                    continue;
                                }
                                if (Matrix[i + k, j + l] == 1)
                                {
                                    szomszed++;
                                }
                            }
                        }
                        //itt van sejt
                        if (Matrix[i, j] == 1)
                        {
                            if (szomszed == 2 || szomszed == 3)
                            {
                                Matrix[i, j] = 1;
                            }
                            else
                            {
                                Matrix[i,j] = 0;
                            }
                        }
                        //itt nincs
                        else
                        {
                            if (szomszed == 3)
                            {
                                Matrix[i, j] = 1;
                            }
                        }
                    }

                }
            }
        }
        public void Run()
        {
            this.Megjelenit();
            this.KovetkezoAllapot();
            Thread.Sleep(500);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Eletjatekszimulator proba = new Eletjatekszimulator(20,80);
            while (true) 
            {
                proba.Run();
            }
        }
    }
}
