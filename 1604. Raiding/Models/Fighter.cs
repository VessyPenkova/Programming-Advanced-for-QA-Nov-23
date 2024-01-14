using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1604._Raiding.Models
{
    public abstract class Fighter : BaseHero
    {
        protected Fighter(string name) : base(name)
        {

        }

        public override string CastAbility()
        {
            return $"{base.CastAbility()} hit for {this.Power} damage";
        }
    }
}
