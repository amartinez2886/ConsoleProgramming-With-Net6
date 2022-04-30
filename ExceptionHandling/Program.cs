// See https://aka.ms/new-console-template for more information


/*
 * 
 * Try - a try block attempts an operation
 * 
 * catch - catch any fatal error or exception that may occur
 * 
 * finally - whether the try or the catch was successful, do this
 * 
 * Throw - end program execution with the error
 * 
 * 
 * 
 * 
 * */

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{

    int quotient = num1 / num2;

    Console.WriteLine($"The result is {quotient.ToString()}.");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"Illegal operation: {ex.Message}");
}

catch (Exception ex)
{
    throw ex;
}

finally
{
    Console.WriteLine("This line runs regardless");
}
// Prompting user for input
