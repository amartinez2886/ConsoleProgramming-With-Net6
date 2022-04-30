// See https://aka.ms/new-console-template for more information
string firstName = "Alberto";
string lastName = "Martinez";
DateTime date = DateTime.Now;

// Print to string
Console.WriteLine(firstName);
// Concatenation
Console.WriteLine(firstName + " " + lastName);
// string length
int length = firstName.Length;
// Replace string parts
string newName = firstName.Replace("e", "a");
Console.WriteLine(newName);
// Append to other string variable

string fullName = firstName + "." + lastName;   
// Split string
string[] splitName = firstName.Split('b');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}
// Compare Strings
string testVariable1 = ""; // string.Empty
string testVariable = string.Empty;

if (string.IsNullOrEmpty(testVariable1))
{
    Console.WriteLine("String is null");
}

if (string.Compare(firstName, lastName) == 0)
{
    Console.WriteLine("Names are equal");
} 
else
{
    Console.WriteLine("Names are not equal");
}
// Convert to String

string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();