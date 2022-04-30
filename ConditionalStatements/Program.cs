// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

// If statements
if (numberOfApples > numberOfOranges)
{
    Console.WriteLine("You have more apples");
} 
else if (numberOfApples < numberOfOranges)
{
    Console.WriteLine("You have more oranges");
}
else if (numberOfApples == numberOfOranges)
{
    Console.WriteLine("You have the same number of apples and oranges");
}


Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch(grade)
{
    case int n when (n < 60):
        Console.WriteLine("You failed");
        break;
    case int n when (n >= 60 && n < 100):
        Console.WriteLine("You passed");
        break;
    case 101:
        Console.WriteLine("Single case example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

// Ternary Operator
var message = numberOfApples > numberOfOranges ? "You have more apples" : "You have more oranges";
Console.WriteLine(message);