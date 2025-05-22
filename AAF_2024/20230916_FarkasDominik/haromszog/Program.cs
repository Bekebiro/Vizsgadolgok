/*Kérje be egy háromszög három oldalának hosszát, és végezze el a következő feladatokat vele:
- állapítsa meg, hogy létezhet-e ilyen háromszög,
- állapítsa meg, hogy a háromszög egyenlő oldalú-e,
- állapítsa meg, hogy a háromszög egyenlő szárú-e,
- állapítsa meg, hogy a háromszög derékszögű-e,
- írja ki, a háromszög kerületét,
- írja ki, a háromszög területét,
- írja ki, a háromszög belső szögeinek összegét!
(A bekért adat minden esetben megfelel a program futásához!!)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.CodeDom;
using System.Runtime.CompilerServices;

namespace haromszog
{
    internal class Program
    {
        static double sideInput(string text)
        {
            double tmp = 0;
            do
            {

                try
                {
                    Console.Write(text);
                    tmp = double.Parse(Console.ReadLine()); /* Convert.ToDouble((Console.ReadLine())*/

                }
                catch (Exception)
                {

                    tmp = 0;
                }

            } while (tmp <= 0);
            return tmp;
        }

        static void Main(string[] args)
        {
            double triangleSide1 = 0;
            double triangleSide2 = 0;
            double triangleSide3 = 0;

            triangleSide1 = sideInput("Kérem az háromszög eslő oldalát: ");
            triangleSide2 = sideInput("Kérem az háromszög második oldalát: ");
            triangleSide3 = sideInput("Kérem az háromszög harmadik oldalát: ");

            #region Feladat1
            bool triangle = false;
            if (triangleSide1 + triangleSide2 > triangleSide3 &&
                triangleSide1 + triangleSide3 > triangleSide2 &&
                triangleSide2 + triangleSide3 > triangleSide1)
            {
                triangle = true;
            }

            #endregion

            #region Feladat2

            bool sameSideTrieangle = triangleSide1 == triangleSide2 &&
                                     triangleSide2 == triangleSide3 &&
                                     triangle;
            #endregion

            #region Feladat 3
            bool isoscelesTriangle = sameSideTrieangle ||
                                     (triangleSide1 == triangleSide2 ||
                                      triangleSide2 == triangleSide3 ||
                                      triangleSide1 == triangleSide3) &&
                                      triangle;


            #endregion
            #region Feladat 4
            bool rightTriangle = Math.Pow(triangleSide1, 2) + Math.Pow(triangleSide2, 2) == Math.Pow(triangleSide3, 2) ||
                                 Math.Pow(triangleSide1, 2) + Math.Pow(triangleSide3, 2) == Math.Pow(triangleSide2, 2) ||
                                 Math.Pow(triangleSide2, 2) + Math.Pow(triangleSide3, 2) == Math.Pow(triangleSide1, 2);

            #endregion
            if (triangle)
            {
                #region Feladat 5
                Console.WriteLine("A háromszög kerülete: {0}", (triangleSide1 + triangleSide2 + triangleSide3).ToString());
                // Console.WriteLine("A háromszög kerülete: {0}", Convert.ToString(triangleSide1 + triangleSide2 + triangleSide3)); 
                //Console.WriteLine($"A háromszög kerülete: {triangleSide1 + triangleSide2 + triangleSide3}"); 



                #endregion
                #region Feladat 6

                #endregion
                #region Feladat 7
                Console.WriteLine("A háromszög belső szögeinek összege: 180°");
                #endregion
            }
            else Console.WriteLine("Az adatok nem egy háromszö9g adatai");
        
            Console.ReadKey();

            
        }
    }
}
