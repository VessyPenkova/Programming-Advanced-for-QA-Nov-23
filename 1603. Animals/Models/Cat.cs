using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603._Animals.Models
{
    public class Cat : Animal
    {
        private string _sound;
        public string Sound { get; set; }
        public Cat(string _name, string _favouriteFood)
            : base(_name, _favouriteFood)
        {
            this.Sound = "MEEOW";
        }

        public override string ExplainSelf()
        {
            return $"{base.ExplainSelf()}{Environment.NewLine}{Sound}";
        }
    }
}
