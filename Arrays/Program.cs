// Declare fixed size array
int[] grades = new int[5];


// Add values to fixed sixe array

// Print values in fixed size array
//for (int i = 0; i < grades.Length; i++)
//{
//    Console.Write("Enter Grade: ");
//    grades[i] = Convert.ToInt32(Console.ReadLine());
//}

//foreach(int grade in grades)
//{
//    Console.WriteLine(grade);
//}


// declare variable size array
string[] studentNames = new string[] {"Test", "student1", "etc..."};
// add values to variable sized array

studentNames.Append("Rick");

foreach(string studentName in studentNames)
{
    Console.WriteLine(studentName);
}
// print values in variable sized aay
