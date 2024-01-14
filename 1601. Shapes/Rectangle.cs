using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1601._Shapes
{
    public class Rectangle : IDrawable
    {
        private int _width;
        private int _height;
        public int Width { get; }
        public int Height { get; set; }

        public Rectangle(int _width, int _height)
        {
            this.Width = _width;
            this.Height = _height;
        }

        public void Draw()
        {
            DrawLine(Width, '*', '*');
            for (int i = 1; i < Height - 1; ++i)
            {
                DrawLine(Width, '*', ' ');
            }
            DrawLine(Width, '*', '*');
        }

        private void DrawLine(int _width, char end, char mid)
        {
            Console.Write(end);

            for (int i = 1; i < _width - 1; ++i)
            {
                Console.Write(mid);
            }

            Console.WriteLine(end);
        }
    }
}
