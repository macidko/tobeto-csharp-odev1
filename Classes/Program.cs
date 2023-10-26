using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class'ın referansı oluşturulur.
            //Classlar(vb.) PascalCase isimlendirmesi ise camelCase olarak yazılır.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            //class oluşturma
            Customer customer = new Customer();
            //class proplarına değer atama - set bloğu
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Eren";
            customer.LastName = "Macit";

            //class oluşturmanın farklı(daha kısa) yolu 
            Customer customer2 = new Customer
            {
               Id2 = 2, City2 = "Istanbul", FirstName2 = "Macit", LastName2 = "Eren"
            };
            //customer2 classının firstname propunu yazdırma - get bloğu
            Console.WriteLine(customer2.FirstName2);

            Console.ReadLine();
        }
    }
}
