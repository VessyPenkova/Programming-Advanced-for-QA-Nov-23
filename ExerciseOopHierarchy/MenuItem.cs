using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public abstract class MenuItem
    {
        private string _name;
        private string _description;
        private decimal _price;

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public MenuItem(string _name, string _description, decimal _price)
        {
            this.Name = _name;
            this.Description = _description;
            this.Price = _price;
        }


        public override string ToString()
        {
            return $"{this.Name} - {this.Description} - ${this.Price}";
        }
    }
}
