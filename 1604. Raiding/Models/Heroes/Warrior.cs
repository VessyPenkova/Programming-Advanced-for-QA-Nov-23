using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1604._Raiding.Models.Heroes
{
    public class Warrior : Fighter
    {
        public override int Power => 100;
        public Warrior(string name) : base(name)
        {
        }

        public override string CastAbility()
        {
            return $"{base.CastAbility()}";
        }
    }
}
