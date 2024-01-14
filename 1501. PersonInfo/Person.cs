using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1501._PersonInfo
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public Person(string _firstName, string _lastName, int _age)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.Age = _age;
        }
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
                }
                _lastName = value;
            }


        }

        public int Age
        {
            get
            {
                return (int)_age;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                _age = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} years old.";
        }
    }
}
