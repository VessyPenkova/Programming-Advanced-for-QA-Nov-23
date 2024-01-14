using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Customer
    {
        private List<Order> _ordersHistory = new();
        public IReadOnlyCollection<Order> OrderHistory => this._ordersHistory.AsReadOnly();


        public string Name { get; set; }
        public string Email { get; set; }


        public Customer(string _name, string _email)
        {
            this.Name = _name;
            this.Email = _email;
        }


        public void AddOrder(Order order)
        {
            this._ordersHistory.Add(order);
        }
    }
}
