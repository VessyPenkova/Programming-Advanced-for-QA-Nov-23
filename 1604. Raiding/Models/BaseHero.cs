using _1604._Raiding.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1604._Raiding.Models
{
    public abstract class BaseHero : IHero
    {
        public BaseHero(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract int Power { get; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {this.Name}";
        }
    }

}
