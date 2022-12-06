using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           int counter = 0;     

           counter++; //counter değerini 1 arttırır.
           Console.WriteLine(counter);

           counter+=2; //counter değerini 2 arttırır.
           Console.WriteLine(counter);

           // int operator farkı  ++variable and variable++

           Console.WriteLine(++counter); //önce arttır sonra yazdır.
           Console.WriteLine(counter++); //önce yazdır sonra arttır.
           */



            //Koşul Operatörleri

            /* int number = 6, number2 = 4;

             Console.WriteLine($"{number} {"=="} {number2} sonuç : {number==number2}");

             Console.WriteLine($"{number} {">"} {number2} sonuç : {number>number2}");

             Console.WriteLine($"{number} {"<"} {number2} sonuç : {number<number2}");

             Console.WriteLine($"{number} {"!="} {number2} sonuç : {number!=number2}");

             Console.WriteLine($"{number} {"<="} {number2} sonuç : {number<=number2}");

             Console.WriteLine($"{number} {">="} {number2} sonuç : {number>=number2}");

             */
            // And -- Or Operator

            /*
            int firstNumber = 15, secondNumber = 20;

            bool result = (firstNumber < secondNumber) && (secondNumber > 15);
            Console.WriteLine("And = " + result);

            result = (firstNumber < secondNumber) || (secondNumber > 15);
            Console.WriteLine("Or = " + result);
            */

            // if /else-if/else şart blokları -- ister sizden bool expression :)
            /*
                        int number = 5;
                        int secondNumber = 10;

                        // c# ternary operator ? : what is this structure .
                        string message = number > secondNumber ? "Sayı 1 büyüktür Sayı 2`Den":
                            number < secondNumber ?
                            "Sayı 1 küçüktür Sayı 2`Den ":"Sayılar Eşittir";

                        Console.WriteLine(message);
            */

            Console.Write("Sayı Giriniz : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Sayı Giriniz : ");
            int secondNumber = int.Parse(Console.ReadLine());

            string message = number > secondNumber ? "Sayı 1 büyüktür Sayı 2`Den" :
                             number < secondNumber ? "Sayı 1 küçüktür Sayı 2`Den " :
                             "Sayılar Eşittir";

            Console.WriteLine(message);

            try
            {

            }
            catch (Exception e)
            {

                Console.WriteLine("");
            }
        }
    }
}
