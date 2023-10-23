using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            double number5 = 10.4; //Ondalıklı sayılar (64bit) 155-16 değer tutabilir
            decimal number6 = 10.4m; //değer sonuna "m" yazılmalı. 28 değer tutabilir.
            char character = 'A'; //Karakter.
            string City = "Ankara"; //Char dizisi.
            bool condition = false; //Durum
            byte number4 = 255; // 0 - 255;
            short number3 = 32767; //  -32768 ve 32767
            int number1 = 2147483647; //-2 147 583 647 ve 2 147 583 6477  (TAMSAYI)
            long number2 = 9223372036854775807; //19 karakterden oluşur. - ve +
            var number7 = 10;
            //number7 = "A";

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine((int)Days.Friday);
            Console.ReadLine();


        }
    }

    enum Days
    {
        Monday=10, Tuesday=20, Wednesday=30, Thursday, Friday, Saturday, Sunday
    }
}
