// See https://aka.ms/new-console-template for more information

Person person = new Person();

string middleName = string.Empty;

Console.WriteLine("Enter First Name");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter middle name:");
middleName = Console.ReadLine();

Console.WriteLine("Enter Age:");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Salary:");
double salary = Convert.ToDouble(Console.ReadLine());
person.setSalary(salary);

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"Name is: {person.getFullName()}");
}
else
{
    Console.WriteLine($"Name is: {person.getFullName(middleName)}");
}

//Console.WriteLine($"First Name is: {person.FirstName}");
//Console.WriteLine($"Last Name is: {person.LastName}");
//Console.WriteLine($"Name is: {person.getFullName()}");
Console.WriteLine($"Age is: {person.Age}");
Console.WriteLine($"Year of birth is {DateUtil.YearOfBirth(person.Age)}");
Console.WriteLine($"Salary is: {person.getSalary()}");

