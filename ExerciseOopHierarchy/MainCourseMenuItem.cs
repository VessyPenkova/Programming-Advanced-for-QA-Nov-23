using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class MainCourseMenuItem : MenuItem
    {
        public MainCourseMenuItem(string _name, string _description, decimal _price)
        : base(_name, _description, _price)
        {
        }

        public override string ToString()
        {
            return $"Main Course: {base.ToString()}";
        }
    }
}
