using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //property
        public int Id { get; set; }
        public string City { get; set; }

        private string _firstName;
        public string FirstName
        {
            //encapsulation - Ancak genelde prop şeklinde kullanılır.
            get
            {
                return "Mr." + _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        //public string FirstName; //field
        public string LastName { get; set; }
    }
}
