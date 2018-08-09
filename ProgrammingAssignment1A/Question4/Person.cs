using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question4
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int YearOfBirth;
        public string GetFullName(string _firstName, string _lastName)
        {
            return _firstName + " " + _lastName;
        }
        public int GetAge(int _YearOfBirth)
        {
            return 2018 - _YearOfBirth;
        }
        public Person(string _firstName, string _lastName)
        {
            GetFullName(_firstName, _lastName);
        }
    }
}
