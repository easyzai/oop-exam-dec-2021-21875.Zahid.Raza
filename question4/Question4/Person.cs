using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question4.Question4
{
    internal class Person
    {
        public string Name { get; set; } 
        public string Phone { get; set; }

        public Person(string _name, string _phone)
        {
            Name = _name;
            Phone = _phone;
        }
        public Person()
        {

        }
    }
}
