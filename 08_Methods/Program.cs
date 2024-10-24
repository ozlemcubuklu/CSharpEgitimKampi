using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region void metotlar


            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();
            #endregion

            #region geriye deger döndürmeyen string parametreli metotlar


            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");


            //void CustomerCard(string name,string surname) {
            //    Console.WriteLine("Müşteri:"+name+" "+surname);
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");

            #endregion

            #region geriye deger döndürmeyen int parametreli metotlar
            //void sum(int number1,int number2,int number3) {
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);

            //}
            //sum(4,5,6);


            #endregion



            #region geriye deger döndüren metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion



            #region geriye deger döndüren string parametreli metotlar
            // string CountryCard(string countryname, string capital, string flagcolor)
            // {
            //     string cardInfo="Ülke= "+countryname +" - Başkent= "+ capital + " - Bayrak Rengi= "+flagcolor;
            //return cardInfo;
            // }

            // Console.WriteLine("Ülke Adını Giriniz=");
            // string x=Console.ReadLine();
            // Console.WriteLine("Başkent giriniz=");
            // string y=Console.ReadLine();
            // Console.WriteLine("Bayrak Regi giriniz=");
            // string z=Console.ReadLine();
            // Console.WriteLine(CountryCard(x,y,z)) ;

            // Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz")) ;
            #endregion


            #region geriye deger döndüren int parametreli metotlar
            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));
            #endregion
            #region Örnek Uygulama
            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli Ögrenci Sınavı geçti. Ortalama=" + result;

                }
                else
                {
                    return student + " isimli Ögrenci başarısız oldu Ortalama=" + result;
                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion
            Console.Read();
        }
    }
}
