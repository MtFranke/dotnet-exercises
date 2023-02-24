namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555
*/
public class Ex13 : IRunner
{
    public void Run()
    {
        Console.Write("Enter a number:");
        int.TryParse(Console.ReadLine(), out var n);
        
        for (int j = 0; j < 3; j++)
            Console.Write(n);

        Console.WriteLine();
        for (int j = 0; j < 3; j++)
        {
            Console.Write("{0} {0}",n);
            Console.WriteLine();

        }
        for (int j = 0; j < 3; j++)
            Console.Write(n);
    }
}

