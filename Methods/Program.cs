using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();

            //var result = Add2(20, 30);


            //int number1;
            //int number2 = 100;

            //var result2 = Add3(out number1, number2);

            //Console.WriteLine(result2);
            //Console.WriteLine(result);


            Console.WriteLine("çarpma : " + Multiply(2, 4));
            Console.WriteLine("çarpma : " + Multiply(2, 4, 5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        //DRY - DONT REPEAT YOURSELF
        //static void Add()
        //{
        //    Console.WriteLine("Added!!!!");
        //}


        //static int Add2(int number1, int number2 = 30) //Default değer yalnızca methodun sonunda olabilir.
        //{
        //    //return number1 + number2;

        //    var result = number1 + number2;
        //    return result;
        //}
        //ref - referans tip (ref tip tanımlanmak zorundadır)
        //out - ref gibi tanımlanmak zorunda değildir. ancak method içerisinde en az 1 kez set edilmelidir.
        //static int Add3 (out int number1, int number2)
        //{
        //    number1 = 30;
        //    return number1 + number2;
        //}

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)//OVERLOAD (parametre kısmı methodun imzasıdır.)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1 = 2, params int[] numbers)// params son parametre olmalı
        {
            return numbers.Sum();
        }
    }
}
