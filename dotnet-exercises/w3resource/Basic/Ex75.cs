using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program which takes a positive number and return the nth odd number.
Sample Output:
1st odd number: 1
2nd odd number: 3
4th odd number: 7
100th odd number: 199
 */
public class Ex75 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(1));
        Console.WriteLine(DoAlgorithm(2));
        Console.WriteLine(DoAlgorithm(4));
        Console.WriteLine(DoAlgorithm(100));
    }

    // [Pure]
    // private static int DoAlgorithm(int oddNumberIndex)
    // {
    //
    //     var currentOddNumberIndex = 0;
    //     var number = 0;
    //     while (oddNumberIndex != currentOddNumberIndex)
    //     {
    //         if (number % 2 == 1)
    //         {
    //             currentOddNumberIndex++;
    //         }
    //
    //         number++;
    //
    //     }
    //
    //     return number -1;
    //
    // }
    
    [Pure]
    private static int DoAlgorithm(int n) 
        => n * 2 - 1;
    
}