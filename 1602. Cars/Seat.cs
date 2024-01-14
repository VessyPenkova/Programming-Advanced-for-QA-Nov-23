using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1602._Cars
{
    public class Seat : ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }

        public Seat(string _model, string _color)
        {
            this.Model = _model;
            this.Color = _color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Color} Seat {Model}");
            sb.AppendLine("Engine start");
            sb.AppendLine("Break!");

            return sb.ToString().Trim();
        }
    }
}
