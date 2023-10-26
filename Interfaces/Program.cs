using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

             
            //Bir interface hiçbir zaman new'lenemez

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());

            Console.ReadLine();

        }

        private static void InterfacesIntro()
        {
            //Tanımladığın manager sınıfı oluştur.
            PersonManager manager = new PersonManager();
            //oluşturduğun manager sınıfına parametre(şu anda nesne) gönder. Nesne (örneğin customer sınıfı) de new anahtarıyla oluşturulmalıdır.
            manager.Add(new Customer { Id = 1, FirstName = "Eren", LastName = "Macit", Address = "Istanbul" });


            //alternatif yazım;
            Customer customer2 = new Customer()
            {
                Id = 1,
                FirstName = "Customer2 Eren",
                LastName = "Macit",
                Address = "Istanbul"
            };
            manager.Add(customer2);


            Customer customer = new Customer()
            {
                Id = 1,
                FirstName = "Customer Eren",
                LastName = "Macit",
                Address = "Istanbul"
            };
            Student student = new Student()
            {
                Id = 1,
                FirstName = "Student Eren",
                LastName = "Macit",
                Departmant = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
            manager.Add(new Worker { FirstName = "Worker Eren" });
        }

        //Soyut Nesne
        //Soyut nesneler tek başına hiçbir anlam ifade etmez.
        //Özellik sağlayıcı?
        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }
        //Somut nesne
        //class yanına tanımlanan bir interface ile birlikte, class içerisinde, interfacede tanımlanmış her şeyi görebilirsin.
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }        
        class Worker: IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

        //Manager ifadesi iş katmanı sınıfları için kullanılır
        class PersonManager
        {
            //Bir nesne de parametre olabilir.
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
        //Inheritance?

        //interface IInterface
        //{
        //Standardı "I" ile başlamasıdır.
        //en büyük kullanma amacı bir temel nesne oluşturup bütün nesneleri ondan "implemente"(yerine getirmek, uygulamak, hayata geçirmek, gerçekleştirmek) etmektir.
        //}
    }
}
