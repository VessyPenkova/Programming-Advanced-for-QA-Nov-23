using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1504._Zoo
{
    public class Animal
    {
        private string _name;
        public string Name { get; set; }
        public Animal(string _name)
        {
            this.Name = _name;
        }
    }
}
