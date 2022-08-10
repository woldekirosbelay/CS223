// Creating shapes 
using _3rd_Assigment;
Rectangle rectangle = new Rectangle();
Circle circle = new Circle();

// Setting properties 
rectangle.width = 2;
rectangle.height = 3;
circle.radius = 6;

// Printing Area and perimeter 
Console.WriteLine("Rectangle");
Console.WriteLine("Area: " + rectangle.getArea());
Console.WriteLine("Perimeter: " + rectangle.getPerimeter()+"\n\n");
Console.WriteLine("Circle");
Console.WriteLine("Area:" + circle.getArea());
Console.WriteLine("Perimeter: "+ circle.getPerimeter());
