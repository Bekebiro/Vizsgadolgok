using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.feladat: ");
            Console.WriteLine("Adja meg N értékét: ");
            int N = 0;
            do
            {
                int szamN = Convert.ToInt32(Console.ReadLine());
                if (szamN >= 1 && szamN <= 10)
                {
                    N += szamN;
                }
                else
                {
                    Console.WriteLine("A szám nem megfelelő, adjon meg egy új számot");
                }
            }while(!(N > 0 && N < 11));

            Console.WriteLine("Adja meg M értékét: ");
            int M = 0;
            do
            {
                int szamM = Convert.ToInt32(Console.ReadLine());
                if (szamM >= 1 && szamM <= 10)
                {
                    M += szamM;
                }
                else
                {
                    Console.WriteLine("A szám nem megfelelő, adjon meg egy új számot");
                }
            } while (!(M > 0 || M < 10));

            Console.WriteLine("2.feladat: Mátrix");
            Random rnd = new Random();

            int[,] arr = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    arr[i, j] = rnd.Next(1, 51);
                    Console.Write(arr[i, j].ToString().PadLeft(3));
                    
                }

                Console.WriteLine();
            }
            //git hub copilot
            //3. feladat

            /*if (N == M)
            {
                Console.WriteLine("3. feladat: Tükrözés mellékáltóra");
                for (int i = 0; i < N; i++)
                {
                   for(int j = 0; j < M; j++)
                    {
                        if(i == j)
                        {
                            Console.Write(arr[i, j].ToString().PadLeft(3));
                        }
                        else
                        {
                            Console.Write(arr[j, i].ToString().PadLeft(3));
                        }
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("A mátrix nem szimetrikus");
            }*/

            Console.WriteLine("3. feladat: Tükrözés főáltóra");
            int[,] tukozes = new int[N, M];
            if (N == M)
            {
                for(int i = 0;i < N; i++)
                {
                    for(int j = 0; j < M; j++)
                    {
                        tukozes[i, j] = arr[j, i];
                        Console.Write(arr[j, i].ToString().PadLeft(3));
                    }
                    Console.WriteLine();
                }
            }

           



            Console.ReadKey();
        }
    }
}
