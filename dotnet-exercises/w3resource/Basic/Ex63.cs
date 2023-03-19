namespace dotnet_exercises.w3resource.Basic;

//Write a C# program to check if a given number present in an array of numbers.
public class Ex63 : IRunner
{
    public void Run()
    {
        var searchedNumber = 5;
        int[] numbers = { 1, 3, 5, 7, 9 };
        Console.WriteLine(numbers.Contains(searchedNumber));
    }
}
