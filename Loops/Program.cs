using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 0; i <= 100; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //int number = WhileLoop();
            //Console.WriteLine("Now number is {0}", number);
           /* doWhileLoop()*/;


            string[] students = new string[3] {"Engin", "Derin", "Salih"}

            foreach (var student in students)
            {
                //student = "Ahmet"; //Readonly 
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }

        private static void doWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static int WhileLoop()
        {
            //ForLoop();
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            return number;
        }

        private static void ForLoop()
        {
            for (int i = 100; i <= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
