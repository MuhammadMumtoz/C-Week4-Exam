var circle = new Circle(5);
System.Console.WriteLine("Radius: "+circle.GetRadius());
circle.SetRadius(100);
System.Console.WriteLine("New radius: "+circle.GetRadius());
System.Console.WriteLine("Area: "+circle.GetArea());
System.Console.WriteLine($"Circumference: {circle.GetCircumference()}");
System.Console.WriteLine(circle.ToString());