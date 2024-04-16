using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i, j;
            for (i = 0; i <= 6; i++)
            {
                for (j = 0; j <= 6; j++)
                {
                    if (j == i || j == 6 - i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();*/
            // to print the pattern of 'I'

            int i, j, k;
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (i == 0 || i == 5 - 1)
                        Console.Write("*");
                    else if (j == 5 / 2)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }

           
            for (i = 6 / 2; i <= 6; i += 2)
            {
                for(j = 1; j < 6 - i; j += 2)
                    {
                    Console.Write(" ");
                    }
                for (j = 1; j <= i; j++)
                    Console.Write("*");


                for (j = 1; j <= 6 - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("\n");
            }
            for (i = 6; i >= 1; i--)
            {
                for(j = i; j < 6; j++)
                    Console.Write(" ");

                for(j = 1; j <= (i * 2) - 1; j++)
                   Console.Write ("*");
                Console.WriteLine("\n");
            }

            for (i = 0; i < 6; i++)
            {
                if (i != 0 && i != 6 - 1)
                    Console.Write("*");
                else
                    Console.Write(" ");
                for (j = 0; j < 6; j++)
                {
                    if (((i == 6 - 1)
                        && j >= 0
                        && j < 6 - 1))
                        Console.Write("*");
                    else if (j == 6 - 1 && i != 0
                            && i != 6 - 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                /*for (k = 0; k <= 2 * i; k++)
                {
                    Console.Write("*");
                }
                *//*for (k = 2 * i; k <= 19; k++)
                {
                    Console.Write("@");
                }
                for (k = 0; k <= 2 * i; k++)
                {
                    Console.Write("*");
                }
                for (k = 2 * i; k <= 19; k++)
                {
                    Console.Write("&");
                }
                for (k = 0; k <= 2 * i; k++)
                {
                    Console.Write("#");
                }*/

                Console.WriteLine();





            }
        }
    }
}






