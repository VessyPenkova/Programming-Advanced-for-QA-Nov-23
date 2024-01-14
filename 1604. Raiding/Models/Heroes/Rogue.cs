using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1604._Raiding.Models.Heroes
{
    public class Rogue : Fighter
    {
        public override int Power => 80;
        public Rogue(string name) : base(name)
        {
        }
        public override string CastAbility()
        {
            return $"{base.CastAbility()}";
        }
    }
}
