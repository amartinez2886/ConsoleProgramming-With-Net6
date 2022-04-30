﻿// See https://aka.ms/new-console-template for more information

// Declare a List
List<string> names = new List<string>();
string name = string.Empty;

// Add values to list
names.Add("Alberto");



Console.WriteLine("Enter names: ");
while (!name.Equals("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

// print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine("Printing names via for each loop");
foreach (string item in names)
{
    Console.WriteLine(item);
}



