namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to count a specified number in a given array of integers.
Test Data:
Input an integer: 5
Sample Output
Number of 5 present in the said array: 2 
*/
public class Ex45 : IRunner
{
    public void Run()
    {
        int[] arr = new[] { 1, 2, 3, 4, 5, 5, 5, 1 };
        Console.Write("Input an integer: ");
        int.TryParse(Console.ReadLine(), out var n);
        var count = arr.Count(x => x == n);
        
        Console.WriteLine($"Number of 5 present in the said array: {count}");
        
    }
}