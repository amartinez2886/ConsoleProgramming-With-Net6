// See https://aka.ms/new-console-template for more information


// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();


// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1986, 11, 28);
Console.WriteLine(dateOfBirth);


// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine(now);

// Create a DateTime from a string
DateTime dateFromString = DateTime.Parse("1/31/2021", CultureInfo.InvariantCulture);
Console.WriteLine("The date from string is " + dateFromString);

// Add Additional Time
now.AddHours(1);
Console.WriteLine("One hour from now is: " + now.AddHours(1));  
Console.WriteLine("One hour from now is: " + now.AddDays(1));  

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);


// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine(dateOnlyOfBirth);

// Time Only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(now);
Console.WriteLine(timeOnlyOfBirth);

Console.WriteLine(dateOfBirth.DayOfWeek);