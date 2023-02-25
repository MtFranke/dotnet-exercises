using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to check if an given integer is within 20 of 100 or 200.
*/
public class Ex22: IRunner
{
    public void Run()
    {
        Console.WriteLine($"90 -> {DoAlgorithm(90)}");
        Console.WriteLine($"210 -> {DoAlgorithm(210)}");
        Console.WriteLine($"121 -> {DoAlgorithm(121)}");
    }

    [Pure]
    private static bool DoAlgorithm(int n)
    {
        const int oneHundred = 100;
        const int twoHundred = 200;
        const int allowedDiffer = 20;
        
        if (Math.Abs(oneHundred - n) <= allowedDiffer)
            return true;
        
        if (Math.Abs(twoHundred - n) <= allowedDiffer)
            return true;

        return false;
    }
}