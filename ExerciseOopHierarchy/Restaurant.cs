using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Restaurant
    {
        private List<Customer> _customers = new List<Customer>();
        private List<MenuItem> _menuItems = new List<MenuItem>();


        public void AddCustomer(Customer customer)
        {
            this._customers.Add(customer);
        }


        public void AddMenuItem(MenuItem item)
        {
            this._menuItems.Add(item);
        }


        public MenuItem GetMenuItem(int index)
        {
            if (index >= _menuItems.Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return this._menuItems[index];
        }

        public void PlaceOrder(Customer customer, Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Menu Items:");
            //foreach (MenuItem menuItem in _menuItems)
            //{
            //    sb.AppendLine(menuItem.ToString());
            //}
            //sb.ToString().Trim();
            //Console.WriteLine(sb);

            Console.WriteLine("Menu Items:");
            foreach (MenuItem menuItem in _menuItems)
            {
                Console.WriteLine(menuItem.ToString());
            }
        }
        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");
            foreach (Order order in customer.OrderHistory)
            {
                Console.WriteLine($"Order Total: ${order.GetTotal()}");
                foreach (MenuItem item in order.Items)
                {
                    Console.WriteLine($"  {item}");
                }
            }
        }
    }
}

//  +  class Restaurant will hold the most logic, combining all classes. Here is what the class will have:
//	+  Field _customers – list of customers.
//	+  Field _menu – list of menu items.
//	+  Method AddCustomer(Customer customer) – adds the given customer to the _customers list.
//	+  Method GetMenuItem(int index) – returns the menu item at the given index.
//	+  Check if the index is in bounds! If not throw an IndexOutOfRangeException.
//  +  Method AddMenuItem(MenuItem item) – adds the given menu item to the _menu list.
//  +  Method PlaceOrder(Customer customer, Order order) – adds the given order to the customers _orderHistory list through the method we wrote.
//  +  Method DisplayMenu() – First write to the console "Menu Items:" then foreach menu item in _menu write the item to the console.
//  +  Method DisplayOrderHistory(Customer customer) – First:
//  +  Write to the console "{customer.Name}'s Order History:".
//  +  Then foreach order in the customers read only order collection write to the console "Order Total: ${order.GetTotal()}".
//  +  Finally foreach item in the orders items write to the console on each line "  {item}".
//
