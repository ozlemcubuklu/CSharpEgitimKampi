
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            string[] cities = {"milano","roma","budapeşte","ankara","istanbul","varşova" };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }


            //int[] numbers = { 234, 345, 54, 6, 67, 87, 34, 234, 635, 24234 };
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach (var number in numbers)
            //{
            //    if (number%2==0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //int total = 0;
            //foreach (int number in numbers)
            //{
            //    total +=number;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>() {1,2,3,4,5,8 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "merhaba";
            //foreach (var h in word)
            //{
            //    Console.WriteLine(h);
            //}


            #endregion

            #region örnek sınav sistemi uygulaması
            Console.WriteLine("*****C# egitim kampı sınav uygulaması ************");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------");
            Console.WriteLine("Sınıfınızda kaç ögrenci var");
            int studentCount = int.Parse(Console.ReadLine());

            Console.WriteLine("------------------------");


            string[] studentNames=new string[studentCount];
            double[] studentExamAvg = new double[studentCount];



            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i+1}. ögrencinin ismini giriniz");
                studentNames[i]= Console.ReadLine();
                double totalExamResult = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"{studentNames[i]} adlı ögrencinin {j+1}.sınav notunu giriniz.");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult+=value;
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResult/3;
            }

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması:{studentExamAvg[i]}");
            
            if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencin dersi geçti");

                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrencin dersten kaldı");
                }
                Console.WriteLine("---------------------------");

            }



            #endregion
        }
    }
}
