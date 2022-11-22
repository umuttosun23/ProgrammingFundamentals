using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Variables
    {
        static void Main(string[] args)
        {
            Console.Title = "Kullanıcıdan değer alma dersi";
            /* int a = 2,b=3;
            Console.WriteLine("{2} {0}+{3}",1, 2, "merhaba", 3);
            Console.WriteLine($"{a} + {b}");
            Console.WriteLine("{0} {1}",a, b);
             */
            /* Read Tek karakteri okur readline tüm satırı okur */
            /*
             * string name;
            Console.Write("Adınızı Giriniz : ");
            name=Console.ReadLine();

            int birthDayYear;
            Console.WriteLine("Doğum Yılınızı Giriniz : ");
            birthDayYear = Convert.ToInt16(Console.ReadLine());

            //13 yerine kullanıcıdan değer alabilirsiniz.
            int number = int.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthDayYear;

            Console.WriteLine("Yaşınız : " + age);
            
            */

            //Math Sınıfı

            /* int us, taban;
             Console.Write("Üs : ");
             us = Convert.ToInt16(Console.ReadLine());

             Console.Write("Taban : ");
             taban = Convert.ToInt16(Console.ReadLine());

             Console.WriteLine("{0} ^ {1} = {2}",us,taban,Math.Pow(us,taban));
            */
            /*Console.Write("Kenar 1 : ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Kenar 2 : ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());
            
            //math pow us alır ilk deger taban ikinci deger ustur
            double sonuc =Math.Sqrt(Math.Pow(kenar1,2)+Math.Pow(kenar2,2));
            double sonuc2 =Math.Pow(Math.Pow(kenar1, 2) + Math.Pow(kenar2, 2), 1/2f);
            // 1/2 yi program 0 kabul ediyor 1/2 yerine 1/2f yada (double)1/2 yazabiliriz

            //sonuc ve sonuc2 aynıdır
            Console.WriteLine("Sonuç : "+sonuc);
            Console.WriteLine("Sonuç : "+sonuc2);
            */
            /*
             * Console.Write("Sayı 1: ");
             int number = Convert.ToInt32(Console.ReadLine());

             Console.Write("Sayı 2: ");
             int number2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("");

             Console.WriteLine("Toplama : {0} + {1}={2}",number,number2,number+number2);
             Console.WriteLine("Çıkarma : {0} - {1}={2}",number,number2,number-number2);
             Console.WriteLine("Bölme :   {0} / {1}={2}",number,number2,number/number2);
             Console.WriteLine("Çarpma :  {0} * {1}={2}",number,number2,number*number2);
             Console.WriteLine("Mod :     {0} % {1}={2}",number,number2,number%number2);
             */
            Console.ReadLine();
        }
    }
}
