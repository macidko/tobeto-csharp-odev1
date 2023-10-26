﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer();

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Eren"
                },
                new Student
                {
                    FirstName = "Derin"
                },
                new Person
                {
                    FirstName = "Salih"
                }
            };

            foreach (Person person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }

        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        //bir nesne birden fazla inheritance alamaz. ancak interface alabilir.
        class Customer : Person
        {
            public string City { get; set; }
        }

        class Student : Person
        {
            public string Departmant { get; set; }
        }
    }
}
