using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If
            //Console.WriteLine("Lütfen Şifreyi Giriniz.");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre dogtru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.WriteLine("Başkent giriniz.");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülke Giriniz.");
            //country = Console.ReadLine();
            //if (country == "türkiye" & capital == "ankara")
            //{
            //    Console.WriteLine("dogru");
            //}
            //else
            //{
            //    Console.WriteLine("hatalı bilgi");
            //}
            //int number;
            //Console.WriteLine("Sayı giriniz.");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı dogru");
            //}
            //else
            //{
            //    Console.WriteLine("sayı yanlış");
            //}


            //int exam1, exam2, exam3, avarage;
            //string result="hata";
            //Console.WriteLine("sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());


            //avarage = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınav ortalaması =" + avarage);

            //if (avarage > 0 & avarage <= 50)
            //{
            //    result = "sonuç vasat";
            //}
            //if (avarage > 50 & avarage <= 70)
            //{
            //    result = "sonuç orta";
            //}
            //if (avarage > 70 & avarage <= 84)
            //{
            //    result = "sonuç iyi";
            //}

            //Console.WriteLine(result);




            //string city;
            //Console.WriteLine("Lütfen şehir girişi yapınız.");
            //city = Console.ReadLine();
            //if (city=="adana" | city== "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut degil");
            //}




            //Console.WriteLine("Lütfen kullanıcı adınızı giriniz.");
            //string username = Console.ReadLine();

            //if (username!="admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.WriteLine("Hoşgeldiniz.");
            //}


            //Console.Read();
            #endregion


            #region Mod işlemleri
            //int number=26;
            //int result = number % 5;

            //Console.WriteLine(result);





            //Console.WriteLine("Lütfen 1.sayıyı giriniz.");
            //int number1 = int.Parse(Console.ReadLine());



            //Console.WriteLine("Lütfen 2.sayıyı giriniz.");
            //int number2 = int.Parse(Console.ReadLine());
            //int result=number1%number2;



            //Console.WriteLine("!. sayının 2. sayıya bölümünden kalan="+result);



            //Console.WriteLine("Lütfen sayıyı giriniz.");
            //int number = int.Parse(Console.ReadLine());

            //if (number%2==0)
            //{
            //    Console.WriteLine("SAyı çifttir.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}




            #endregion
            #region char degişkenler ve karar yapıları
            //char team;
            //Console.WriteLine("Lütfen takım sembolünü giriniz.");
            //team=char.Parse(Console.ReadLine());


            //if(team=='g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}


            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}

            #endregion


            #region örnek proje uygulaması
            //Console.WriteLine("************C# Eğitim Kampı Restorant");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------");
            //Console.WriteLine("1. Anayemekler");
            //Console.WriteLine("2. Çorbalar");
            //Console.WriteLine("3. Pizzalar");
            //Console.WriteLine("4. İçecekler");
            //Console.WriteLine("5. Tatlılar");


            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //string menuItem;
            //Console.WriteLine("Detayını Görmek istediginiz menü seçimi=");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Ana Yemekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Köri Soslu Tavuk");
            //    Console.WriteLine("2. Kızartma Tabagı");
            //    Console.WriteLine("3. Fasulye Pilav");
            //    Console.WriteLine("4. Fırında Somon");
            //    Console.WriteLine("5. Patlıcan Musakka");

            //    Console.WriteLine("-----------Ana Yemekler--------------");
            //    Console.WriteLine();
            //}


            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Çorbalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Mercimek Çorbası");
            //    Console.WriteLine("2. Ezogelin Çorbası");

            //    Console.WriteLine("-----------Çorbalar--------------");
            //    Console.WriteLine();
            //}




            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Pizzalar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Akdeniz Pizzası");
            //    Console.WriteLine("2. Margaritha");
            //    Console.WriteLine("3. Tavuklu Pizza");

            //    Console.WriteLine("-----------Pizzalar--------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------İçecekler--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Kola");
            //    Console.WriteLine("2. Ayran");
            //    Console.WriteLine("3. Su");

            //    Console.WriteLine("-----------İçecekler--------------");
            //    Console.WriteLine();
            //}


            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-----------Tatlılar--------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1. Triliçe");
            //    Console.WriteLine("2. Kazandibi");
            //    Console.WriteLine("3. Sütlaç");

            //    Console.WriteLine("-----------Tatlılar--------------");
            //    Console.WriteLine();
            //}

            //Console.WriteLine();
            //  Console.Read();
            #endregion


            #region switch case

            Console.WriteLine("Lütfen ay girişi yapınız.");
            int monthNumber=int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("Ocak"); 
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                case 5:
                    Console.WriteLine("Mayıs");
                    break;
                case 6:
                    Console.WriteLine("Haziran");
                    break;
                case 7:
                    Console.WriteLine("Temmuz");
                    break;
                case 8:
                    Console.WriteLine("Agustos");
                    break;
                case 9:
                    Console.WriteLine("Eylül");
                    break;
                case 10:
                    Console.WriteLine("Ekim");
                    break;
                case 11:
                    Console.WriteLine("Kasım");
                    break;
                case 12:
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Hatalı giriş");
                    break;
            }
            Console.Read();
            #endregion




            #region Switch case hesap makinesi
            int number1, number2, result;
            char symbol;

            Console.WriteLine("1. sayıyı giriniz.");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz.");
            number2 = int.Parse(Console.ReadLine());


            Console.WriteLine("Lütfen yapmak istediginiz işlemi giriniz.");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam="+result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark=" + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Çarpım=" + result);
                    break;
                case '*':
                    result = number1 *number2;
                    Console.WriteLine("Bölüm=" + result);
                    break;
            }
            #endregion







        }
    }
}
