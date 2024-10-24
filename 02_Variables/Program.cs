using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double degişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);


            //Console.WriteLine("*******Fiyat Listesi*****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("-------- Elma Birim Fiyatı="+applePrice+" TL");
            //Console.WriteLine("-------- Portakal Birim Fiyatı=" + orangePrice + " TL");
            //Console.WriteLine("-------- Çilek Birim Fiyatı=" + strawberryPrice + " TL");
            //Console.WriteLine("-------- Patates Birim Fiyatı=" + potatoPrice + " TL");
            //Console.WriteLine("-------- Domates Birim Fiyatı=" + tomatoPrice + " TL");

            //double appleGram,orangeGram,strawberryGram,potatoGram,tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice=orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalePrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice=tomatoPrice * tomatoGram;
            //Console.WriteLine("Alınan Ürün: Elma - "+" Birim Fiyatı: "+applePrice+" - Gramaj: "+appleGram+" -Toplam Tutar:"+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - "+" Birim Fiyatı: "+orangePrice+" - Gramaj: "+orangeGram+" -Toplam Tutar:"+orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - "+" Birim Fiyatı: "+strawberryPrice+" - Gramaj: "+strawberryGram+" -Toplam Tutar:"+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - "+" Birim Fiyatı: "+potatoPrice+" - Gramaj: "+potatoGram+" -Toplam Tutar:"+potatoTotalePrice);
            //Console.WriteLine("Alınan Ürün: Domates - "+" Birim Fiyatı: "+tomatoPrice+" - Gramaj: "+tomatoPrice+" -Toplam Tutar:"+tomatoTotalPrice);


            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalePrice + tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar= "+shoppingTotalPrice+ " TL");
            #endregion





            #region char degişkenler
            //char symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion



            #region kalvyeden veri girişi
            //Console.WriteLine("**** C# Hava Yolu Yolcu Bilgisi**********");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.WriteLine("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.WriteLine("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.WriteLine("Yolcu İlçe: ");
            //passengerDistrict = Console.ReadLine();
            //Console.WriteLine("Yolcu Şehir: ");
            //passengerCity = Console.ReadLine();
            //Console.WriteLine("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.WriteLine("Yolcu TcKimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("Yolcu Tc Kimlik No:"+passengerIdentityNumber + " -Yolcu Adı Soyadı: "+ passengerName+" "+passengerSurname+" "+passengerDistrict+" / "+passengerCity+" "+passengerAge);
            //Console.WriteLine();
            #endregion



            #region kalvyeden tam sayı girişleri ve dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;
            //Console.WriteLine("Lütfen aldıgınız ayakkabı sayısını ggiriniz:");
            //shoeCount=int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldıgınız bilgisayar sayısını ggiriniz:");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldıgınız sandalye sayısını ggiriniz:");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen aldıgınız televizyon sayısını ggiriniz:");
            //tvCount = int.Parse(Console.ReadLine());


            //int totalPrice=shoeCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvPrice*tvPrice;
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar= "+totalPrice);
            #endregion






            #region kalvyeden ondalıklı sayı girişleri ve dönüşümler

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1. Sınav Notunu Griniz:");
            //exam1= double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2. Sınav Notunu Griniz:");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. Sınav Notunu Griniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2+exam3) / 3;
            //Console.WriteLine("Sınav Ortalamanız: "+result);
            #endregion



            #region kalvyedenkarakter girişleri ve dönüşümler

            char gender;
            Console.WriteLine("Lütfen Cinsiyet Giriniz:");
            gender=char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiginiz Cinsiyet= "+gender);
            #endregion






            Console.Read();
        }
    }
}
