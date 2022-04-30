// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter Length:");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Width:");
int width = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter height:");
int height = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube(width, height, length);

var triangle = new Triangle() { Height = height, Length = length, Hypotenuse = 10};
var rectangle = new Rectangle() { Width = width, Length = length };

cube.Length = length;
cube.Width = width;
cube.Height = height;

triangle.Length = length;
triangle.Height = height;

rectangle.Length = length;
rectangle.Width = width;

Console.WriteLine($"Cube Area is {cube.getArea()}");
Console.WriteLine($"Cube Area is {cube.getVolume()}");

Console.WriteLine($"Triangle Area is {triangle.getArea()}");
Console.WriteLine($"Rectangle Area is {rectangle.getArea()}");