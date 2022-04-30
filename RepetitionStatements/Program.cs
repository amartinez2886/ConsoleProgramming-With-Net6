// See https://aka.ms/new-console-template for more information

// For Loop (Counter controlled)
//for (int i = 0; i < 10; i++) { 
//    Console.WriteLine("I am in a loop");
//    Console.WriteLine($"Counter value is {i}");
//}

// While Loop (Condition Controlled - Pre Check)
//int n = 0;
//while(n < 5)
//{
//    Console.WriteLine("Input a number: ");
//    n = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"You entered {n}");
    
//}

//Console.WriteLine();
//Console.WriteLine("While loop finished");
// Do... While Loop (Condition controlled - Post Check)
int p = 0;

do
{
    Console.WriteLine("Input a number: ");
    p = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {p}");

} while (p < 5);

// For each loop
