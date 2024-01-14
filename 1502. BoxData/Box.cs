using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1502._BoxData
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;
        public Box(double _length, double _width, double _height)
        {
            ValidateDimension(_length, "Length");
            ValidateDimension(_width, "Width");
            ValidateDimension(_height, "Height");

            this.Length = _length;
            this.Width = _width;
            this.Height = _height;
        }

        private void ValidateDimension(double dimension, string propertyName)
        {
            if (dimension <= 0)
            {
                throw new ArgumentException($"{propertyName} cannot be zero or negative.");
            }
        }

        public double Length { get; }

        public double Width { get; }

        public double Height { get; }

        public double SurfaceArea()
        {
            double area = (2 * _length * _width + 2 * _length * _height + 2 * _width * _height);
            return area;
        }
        public double Volume()
        {
            double volume = (_length * _width * _height);
            return volume;
        }

        public override string ToString()
        {
            return $"Surface Area – {SurfaceArea():F2}{Environment.NewLine}Volume - {Volume():F2}";
        }
    }
}
