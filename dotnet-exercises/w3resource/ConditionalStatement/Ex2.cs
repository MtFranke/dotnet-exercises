namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to check whether a given number is even or odd.
Test Data : 15
Expected Output :
15 is an odd integer
*/
public class Ex2 : IRunner
{
    public void Run()
    {
        int.TryParse(Console.ReadLine(), out var n);
        Console.WriteLine(n % 2 == 1 ? $"{n} is an odd integer" : $"{n} is an even integer");
    }
}