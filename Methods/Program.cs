// See https://aka.ms/new-console-template for more information


// Prototype - Defines the function (type, name, parameters)
// Definition - has the code. it contains the code block
// Function call - Makes the function
// Void Functions - completes a task and moves along
// YAGNI - You are not going to need it

void PrintName()
{
    Console.WriteLine("Alberto Martinez");
}



void Addition(int num1, int num2)
{
    Console.WriteLine($"The addition of {num1} and {num2} is {num1 + num2}.");
}

int LargestNumber(int num1, int num2, int num3)
{
    int largest = num1;

    if (largest < num2)
    {
        largest = num2;
    }
    
    if (largest < num3)
    {
        largest = num3;
    }
    return largest;
}

// value returning functions
Console.WriteLine("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());


int result = LargestNumber(number1, number2, number3);

Console.WriteLine(result);

//Addition(6, 14);

//PrintName();



