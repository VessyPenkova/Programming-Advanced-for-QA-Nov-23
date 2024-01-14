using _1601._Shapes;
using System;


Console.WriteLine("Uncomment Code");
int radius = int.Parse(Console.ReadLine()!);
IDrawable circle = new Circle(radius);

int width = int.Parse(Console.ReadLine()!);
int height = int.Parse(Console.ReadLine()!);
IDrawable rectangle = new Rectangle(width, height);

circle.Draw();
rectangle.Draw();
