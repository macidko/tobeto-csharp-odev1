using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string ref tip!
            //string student1 = "Engin";
            //string student2 = "Derin";
            //string student3 = "Salih";

            //string[] students = new string[3]; // new string[3] { "Engin", "Derin", "Salih"}
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

            //string[] students2 = new[] { "Engin", "Derin", "Salih" };

            //string[] students3 = { "Engin", "Derin", "Salih" };


            //foreach (var student in students3)
            //{
            //    Console.WriteLine(student);
            //}

            //Multi dimentional
            string[,] regions = new string[5, 3]
                {
                    {"İstanbul","İzmit","Balıkesir"},
                    {"Ankara","Konya","Kırıkkale"},
                    {"Antalya","Adana","Mersin"},
                    {"Rize","Trabzon","Samsun"},
                    {"İzmir","Muğla","Manisa"},
                };
            //regions[0, 0] = "İstanbul";

            //getupperbound bak
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("*********************");
            }
            Console.ReadLine();

        }
    }
}
