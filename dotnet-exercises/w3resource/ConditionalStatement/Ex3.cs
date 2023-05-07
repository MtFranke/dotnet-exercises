namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to check whether a given number is positive or negative.
Test Data : 14
Expected Output :
14 is a positive number
*/

public class Ex3 : IRunner
{
    public void Run()
    {
        int.TryParse(Console.ReadLine(), out var n);
        
        if(n % 2 == 0)
            Console.WriteLine($"{n} is a positive number ");
        else
            Console.WriteLine($"{n} is a negative number ");

    }
}