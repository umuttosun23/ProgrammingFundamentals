using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFundamentals
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.Title = "Hello World";
            /*C#`Ta ekrana yazı yazdırmak için
             Console sınıfından Write ve WriteLine
             methodlarını kullanırız.
             WriteLine kullanırsak kendisinden sonra 
             gelen satırı bir alta geçirir.
            */
            Console.WriteLine("Hello World!");
            Console.WriteLine("I`m learning programming");

            /*Değişkenler bir değer saklamak için
             kullanılır birçok değişken vardır*/

            int age = 18;
            Console.WriteLine(age);

            /*******************************/

            string name = "Adem Eraslan";
            Console.WriteLine(name);

            /*******************************/

            double pi = 3.14;
            Console.WriteLine(pi);

            /*******************************/

            char gender = 'G';
            Console.WriteLine(gender);

            /*******************************/

            bool isRead = false;
            Console.WriteLine(isRead);

            /*
             * /n komutu bir alt satıra geçirir.
             * /t komutu bir tab boşluğu bırakır.
            */

            Console.WriteLine("This is test message\nTest Completed!\t------");

            Console.Read();

        }
    }
}
