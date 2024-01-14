using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1601._Shapes
{
    public class Circle : IDrawable
    {
        private int _radius;
        public int Radius { get; }

        public Circle(int _radius)
        {
            this.Radius = _radius;
        }
        public void Draw()
        {
            double radiusIn = Radius - 0.4;
            double radiusOut = Radius + 0.4;

            for (double x = Radius; x >= -Radius; --x)
            {
                for (double y = -Radius; y < radiusOut; y += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= radiusIn * radiusIn && value <= radiusOut * radiusOut)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
