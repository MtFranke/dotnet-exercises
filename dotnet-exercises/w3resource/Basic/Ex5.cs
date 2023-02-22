namespace dotnet_exercises.w3resource.basic;

/// <summary>
/// Write a C# Sharp program to swap two numbers. Go to the editor
///Test Data:
///Input the First Number : 5
///Input the Second Number : 6
///Expected Output:
///After Swapping :
///First Number : 6
///Second Number : 5 
/// </summary>
public class Ex5 : IRunner
{
    public void Run()
    {
        var a = 5;
        var b = 6;
        Console.WriteLine($"Value of a: {a} and b: {b}");
        Console.WriteLine($"Swapping");
        (a, b) = (b, a);
        Console.WriteLine($"Value of a: {a} and b: {b}");
    }
}