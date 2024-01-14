using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class DessertMenuItem : MenuItem
    {
        public DessertMenuItem(string _name, string _description, decimal _price)
        : base(_name, _description, _price)
        {
        }

        public override string ToString()
        {
            return $"Dessert: {base.ToString()}";
        }
    }
}
