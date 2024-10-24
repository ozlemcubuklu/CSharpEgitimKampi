﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region altalta 10 yıldız yazdırma

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("*");
            }
            #endregion


            #region yanyana 10 yıldız yazdırma

            for (int i = 0; i < args.Length; i++)
            {
                Console.Write("*");
            }
            #endregion




            #region altalta ve yanyana 10 yıldız yazdırma

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine("**********");
            }
            #endregion


            #region dik üçgen

            //for (int i = 0; i <=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {

            //         Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion



            #region  ters dik üçgen

            for (int i = 5; i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion


            #region  dik ve ters üçgen 

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int i = 4; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion














            #region  baklava dilmi
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1; j>0; j--)
            //    {

            //        Console.Write(" ");
            //    }
            //    for (int k= 1;k<=2*i-1; k++)
            //    {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = n-1; i>=1; i--)
            //{
            //    for (int j = n-1; j >0; j--)
            //    {

            //        Console.Write(" ");
            //    }
            //    for (int k =1; k <= 2*i-1; k++)
            //    {

            //    Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");

            //    }
            //    for (int k = 1; k < 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            #endregion



            #region ters piramit
            int n = 5;
            for (int i = n; i >=1; i--)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");

                }
                for (int k = 1; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
            #endregion
            Console.Read();





        }
    }
}
