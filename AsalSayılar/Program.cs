using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (IsPrimeNumber(6))
            {
                Console.WriteLine("This is a Prime Number");
            }
            else { Console.WriteLine("This is a not Prime Number"); }
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    //break;
                    i = number;
                }
            }
            return result;
        }
    }
}
