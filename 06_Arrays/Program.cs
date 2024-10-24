using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region temel dizi örnekleri
            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";
            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";
            //Console.WriteLine(cities[5]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = {"prag","roma","atina","ankara","bursa" };
            //Console.WriteLine(cities[2]);
            #endregion


            #region dizideki tüm elemanları listeleme
            //string[] colors = {"sarı","kırmızı","beyaz","mavi","yeşil","turuncu","pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 4, 75, 345, 345, 57, 787, 98, 34, 08, 567, 234, 122 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        if (numbers[i]%3==0)
            //        {
            //            Console.WriteLine(numbers[i]);
            //        }
            //    }
            //}

            //char [] symbols = { 'A', 'b', 'c', 'd', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}



            //int[] myArray = { 23, 65, 345, 37, 765, 568, 876, 67, 23, 432 };
            //int maxnumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxnumber)
            //    {
            //        maxnumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxnumber);


            //string[] persons = {"ali","ayşe","ahmet","buse","cem","deniz" };

            //Console.WriteLine(persons.Length);


            //int[] numbers = { 23, 543, 234, 6, 654, 3452, 856, 97, 45, 3 };
            ////Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region dizi metotları
            //string[] customers = { "ali","buse","ayşegül","merve","çınar","kaya"};
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);


            //int[] numbers = { 45, 3, 654, 346, 76, 45, 57, 65, 87, 65, 53 };
            //Console.WriteLine("Dizinin en büyük elemanı="+numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı="+numbers.Min());


            #endregion


            #region kullanıcıdan deger alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. degeri giriniz.");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("-----------------------");



            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = { 10,20,30,40,50};
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);


            int[] numbers = {1, 2, 3,4,5,6,7,8,9,0};
            Console.WriteLine("Çift Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2==0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            Console.WriteLine("------------------");
            Console.WriteLine("Tek Sayılar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
            #endregion
            Console.Read();
        }
    }
}
