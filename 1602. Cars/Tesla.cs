using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1602._Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public int Battery { get; set; }

        public Tesla(string _model, string _color, int _battery)
        {
            this.Model = _model;
            this.Color = _color;

            this.Battery = _battery;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Color} Tesla Model {Model} with {Battery} Batteries");
            sb.AppendLine("Engine start");
            sb.AppendLine("Break!");

            return sb.ToString().TrimEnd();
        }
    }
}
