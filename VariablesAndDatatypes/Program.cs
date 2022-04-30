// See https://aka.ms/new-console-template for more information

// Variable declarations and types
string fullName = string.Empty;
int age = 0;
double salary = 0.0;
float salaryAmt = 0.0f;
decimal salaryAmount = 0.0m;
char gender = char.MinValue;
bool working = false;

// Prompting user for input
Console.Write("Please enter your name: ");
fullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your gender: ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working? (true or false) ");
working = Convert.ToBoolean(Console.ReadLine());

// Print Information
Console.WriteLine($"Your name is: {fullName}");
Console.WriteLine($"Your age is {age}");
Console.WriteLine($"Your salary is {salary}");
Console.WriteLine($"Your gender is {gender}");
Console.WriteLine($"You are employed: {working}");