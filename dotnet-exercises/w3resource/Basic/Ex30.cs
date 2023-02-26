using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to convert a hexadecimal number to decimal number. Go to the editor
Sample Output:
Hexadecimal number: 4B0
Convert to-
Decimal number: 1200 
*/
public class Ex30 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm("4B0")}");
    }

    [Pure]
    private static decimal DoAlgorithm(string hexNumber)
        => Convert.ToInt32(hexNumber,16);
}