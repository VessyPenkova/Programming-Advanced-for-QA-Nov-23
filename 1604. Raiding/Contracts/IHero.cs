using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1604._Raiding.Contracts
{
    public interface IHero
    {
        string Name { get; }

        int Power { get; }

        string CastAbility();
    }

}
