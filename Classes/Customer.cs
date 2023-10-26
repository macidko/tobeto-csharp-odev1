using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Customer
    {
        //field tanımlamak
        public string FirstNameField;

        //prop(property) tanımlama
        //kısayol - prop + tab
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //Neden prop olarak tanımlanıyor? (get, set)
        //encapsulation
        public int Id2 { get; set; }

        private string _firstName;
        public string FirstName2
        {
            get { return "Mr. " + _firstName; }
            set { _firstName = value; }
        }
        public string LastName2 { get; set; }
        public string City2 { get; set; }
    }
}
