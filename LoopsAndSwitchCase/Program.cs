using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAndSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int choose;
            while (true)
            {
                Console.Write("1-12 Arasında Ay Değeri : ");
                choose = int.Parse(Console.ReadLine());

                if (choose == -1) break;

                Console.Write("\n");

                switch (choose)
                {
                    case 1: Console.WriteLine("Ocak Ayı Şeçildi !"); break;
                    case 2: Console.WriteLine("Şubat Ayı Şeçildi !"); break;
                    case 3: Console.WriteLine("Mart Ayı Şeçildi !"); break;
                    case 4: Console.WriteLine("Nisan Ayı Şeçildi !"); break;
                    case 5: Console.WriteLine("Mayıs Ayı Şeçildi !"); break;
                    case 6: Console.WriteLine("Haziran Ayı Şeçildi !"); break;
                    case 7: Console.WriteLine("Temmuz Ayı Şeçildi !"); break;
                    case 8: Console.WriteLine("Ağustos Ayı Şeçildi !"); break;
                    case 9: Console.WriteLine("Eylül Ayı Şeçildi !"); break;
                    case 10: Console.WriteLine("Ekim Ayı Şeçildi !"); break;
                    case 11: Console.WriteLine("Kasım Ayı Şeçildi !"); break;
                    case 12: Console.WriteLine("Aralık Ayı Şeçildi !"); break;

                    default: Console.WriteLine("Böyle Bir Ay Yok! Lütfen Doğru Bir Giriş Yapınız"); break;


                }

                Console.WriteLine("\nÇıkış için -1 tuşuna basınız...\n");
                Thread.Sleep(1000);
                Console.Clear();
            }*/

            /*char letterNote;
            bool control = true;
            while (control)
            {
                Console.Write("Harf Notunuz : ");
                letterNote = char.Parse(Console.ReadLine());
              
                Console.Write("\n");

                switch (char.ToUpper(letterNote))
                {
                    case 'A': Console.WriteLine("Pek iyi!"); break;
                    case 'B': Console.WriteLine("İyi!"); break;
                    case 'C': Console.WriteLine("Orta!"); break;
                    case 'D': Console.WriteLine("Eh işte!"); break;
                    case 'E': Console.WriteLine("Kötü!"); break;
                    case 'F': Console.WriteLine("Çok Kötü!"); break;
                    case '1': control = false;  break;
                  
                    default: Console.WriteLine("Böyle Bir Not Yok! Lütfen Doğru Bir Giriş Yapınız"); break;
                }
                Console.WriteLine("\n Çıkış İçin 1 Tuşuna Basınız \n");
                Thread.Sleep(1000);
                Console.Clear();
            }*/

            /*int counter = 0;
            while (counter < 200) Console.WriteLine((counter++) + " Merhaba");*/

            /* int totalForOne=0, totalForDouble=0, counter = 0;

             while (counter<200)
             {
                 if (counter % 2 == 0) totalForDouble += counter;
                 else totalForOne += counter;
                 counter++;
             }
             Console.WriteLine($"Tek Toplam : {totalForOne}\nÇift Toplam : {totalForDouble}\n\nTek Çift Toplam Oran {totalForOne/totalForDouble}");*/

            /*Console.WriteLine("For Kaç Kere Çalışssın ?");
            int lengthFor = int.Parse(Console.ReadLine());

            for (int i = 0; i < lengthFor; i++) if (i % 3 == 0) Console.WriteLine(i + " 3`E Tam Bölünür.");*/
        }
    }
}
