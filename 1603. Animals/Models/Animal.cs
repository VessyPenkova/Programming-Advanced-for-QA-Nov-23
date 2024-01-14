using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1603._Animals.Models
{
    public abstract class Animal
    {
        private string _name;
        private string _favouriteFood;
        public string Name { get; }
        public string FavouriteFood { get; set; }

        public Animal(string _name, string _favouriteFood)
        {
            this.Name = _name;
            this.FavouriteFood = _favouriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}
