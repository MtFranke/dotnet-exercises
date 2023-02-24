namespace dotnet_exercises.w3resource.basic;

/*
 Write a C# program to that takes a number as input and display it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}. 
 
Test Data:
Enter a digit: 25
Expected Output:
25 25 25 25
25252525
25 25 25 25
25252525
*/
public class Ex12 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Enter a digit:");
        int.TryParse(Console.ReadLine(), out int n);
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("{0} {0} {0} {0}", n);
            Console.WriteLine("{0}{0}{0}{0}", n);
        }
    }
}