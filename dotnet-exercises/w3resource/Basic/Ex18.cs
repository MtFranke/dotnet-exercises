namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to check two given integers and return true if one is negative and one is positive.
Sample Output:
Input first integer:
-5
Input second integer:
25
Check if one is negative and one is positive:
True 
*/

public class Ex18 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Input first integer");
        int.TryParse(Console.ReadLine(), out var firstInteger);
        
        Console.WriteLine("Input second integer");
        int.TryParse(Console.ReadLine(), out var secondInteger);
        
        Console.WriteLine($"{DoAlgorithm(firstInteger, secondInteger)}");
    }

    private static bool DoAlgorithm(int x, int y)
        => (x > 0 && y < 0) || (x < 0 && y > 0);
    
}