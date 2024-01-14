using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603._Animals.Models
{
    public class Dog : Animal
    {
        private string _sound;
        public string Sound { get; set; }
        public Dog(string _name, string _favouriteFood)
            : base(_name, _favouriteFood)
        {
            this.Sound = "BORK";
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}{Environment.NewLine}{Sound}";
        }
    }
}
