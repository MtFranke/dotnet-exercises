using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;
/*
Write a C# program which will accept a list of integers and checks how many integers are needed to complete the range.
Sample Example [1, 3, 4, 7, 9], between 1-9 -> 2, 5, 6, 8 are not present in the list.
So output will be 4.
*/
public class Ex58 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(new[] { 0, 10 })}");
        Console.WriteLine($"{DoAlgorithm(new[] { 0, 10, 10 })}");
        Console.WriteLine($"{DoAlgorithm(new[] { 1, 3, 4, 7, 9 })}"); 
        Console.WriteLine($"{DoAlgorithm(new[] { 1, 2, 3, 4, 7, 8, 9 })}"); 
    }

    // [Pure]
    // private static int DoAlgorithm(int[] arr)
    // {
    //     var counter = 0;
    //     var sortedList = arr.ToList();
    //     sortedList.Sort();
    //
    //     for (var i = sortedList.Min(); i < sortedList.Max(); i++)
    //     {
    //         if (!sortedList.Contains(i))
    //         {
    //             counter++;
    //         }
    //     }
    //     
    //     return counter;
    // }
    
    [Pure]
    private static int DoAlgorithm(int[] arr)
    {
        var distinctNumbers = arr.Distinct();
        var maxValue = arr.Max();
        var minValue = arr.Min();
        
        var counted = Enumerable
            .Range(minValue, maxValue)
            .Except(distinctNumbers)
            .Count();

        return counted;
    }
}