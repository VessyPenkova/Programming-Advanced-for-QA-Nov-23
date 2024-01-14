
using System;

using _1602._Cars;

Console.WriteLine("Uncomment Code");
ICar seat = new Seat("Leon", "Grey");
ICar tesla = new Tesla("Model 3", "Red", 2);

Console.WriteLine(seat.ToString());
Console.WriteLine(tesla.ToString());
