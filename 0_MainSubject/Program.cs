using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_MainSubject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            //Console.Write("Merhaba Dünya");
            //Console.WriteLine("Selam");


            Console.WriteLine("****** Yemek Kategorileri");
            Console.WriteLine();
            Console.WriteLine("1- Çorbalar");
            Console.WriteLine("2- Anayemekler");
            Console.WriteLine("3- Soguk Başlangılar");
            Console.WriteLine("4- Salatalar");
            Console.WriteLine("5- Tatlılar");
            Console.WriteLine("6- İçecekler");
            Console.WriteLine();
            Console.WriteLine("****** Yemek Kategorileri");

            #endregion

            #region Degişkenler

            string name;
            name = "Özlem";
            Console.WriteLine(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Özlem";
            customerSurname = "Anı";
            customerPhone = "+9015557755";
            customerEmail = "ozlemcbkl@gmail.com";
            district = "Sultabeyli";
            city = "İstanbul";
            Console.WriteLine( "********* Rezervasyon Kartı *********");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Müşteri: "+customerName+" "+customerSurname);
            Console.WriteLine("İletişim: "+customerPhone);
            Console.WriteLine("Email: "+customerEmail);
            Console.WriteLine("Adres: "+district+"/"+city);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine();
            customerName = "Ayşegül";
            customerSurname = "Kaya";
            customerPhone = "+9054545555";
            customerEmail = "aysegul@gmil.com";
            district = "Kadıköy";
            city = "İstanbul";
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);

            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Int Degişkenler
            //int number = 24;
            //Console.WriteLine(number);


            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("*******Restorant Menu Fiyatı **********");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger Fiyatı: "+hamburgerPrice+" TL");
            Console.WriteLine("----- Pizza Fiyatı: "+pizzaPrice+" TL");
            Console.WriteLine("----- Kola Fiyatı: "+cokePrice+" TL");
            Console.WriteLine("----- Limonata Fiyatı: "+lemonadePrice+" TL");
            Console.WriteLine("----- Kızartma Fiyatı: "+friesPrice+" TL");
            Console.WriteLine("----- Su Fiyatı: "+waterPrice+" TL");
            Console.WriteLine();
            Console.WriteLine("*******Restorant Menu Fiyatı **********");
            Console.WriteLine();

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFricePrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount =0;
            int lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFricePrice=friesPrice * friesCount;
            totalPizzaPrice=pizzaPrice * pizzaCount;
            totalLemonadePrice=lemonadePrice * lemonadeCount;
            Console.WriteLine("---------------------");
            Console.WriteLine("Hamburger Tutarı: "+totalHamburgerPrice+" TL");
            Console.WriteLine("Pizza Tutarı: "+totalPizzaPrice+" TL");
            Console.WriteLine("Kızartma Tutarı: "+totalFricePrice+" TL");
            Console.WriteLine("Kola Tutarı: "+totalCokePrice+" TL");
            Console.WriteLine("Limonata Tutarı: "+totalLemonadePrice+" TL");
            Console.WriteLine("Su Tutarı: "+totalWaterPrice+" TL");


            int totalPrice = totalHamburgerPrice + totalLemonadePrice + totalPizzaPrice + totalWaterPrice + totalCokePrice + totalFricePrice;
            Console.WriteLine("Toplam Ödenecek Tutar="+totalPrice+" TL");
            #endregion





            Console.Read();
        }
    }
}
