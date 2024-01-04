using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1204._Vehicle
{
    public class Catalogue
    {
        public Catalogue()
        {
            TruckList = new();
            CarList = new();
        }

        public List<Truck> TruckList { get; set; }

        public List<Car> CarList { get; set; }
    }

}
