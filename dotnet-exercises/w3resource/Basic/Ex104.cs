using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to compare equality of three integers and calculate how many integers have the same value.
Sample Data:
(1,2, 3) -> 0
(1,3,3) -> 2
(3,3,3) -> 3
*/
public class Ex104 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(new[] { 1, 2, 3 })); 
        Console.WriteLine(DoAlgorithm(new[] { 1, 3, 3 })); 
        Console.WriteLine(DoAlgorithm(new[] { 3, 3, 3 })); 
    }

    [Pure]
    private static int DoAlgorithm(IEnumerable<int> nums)
    {
        var dist = nums.Distinct().Count();
        var result = dist switch
        {
            3 => 0,
            2 => 2,
            1 => 3,
            _ => -1
        };

        return result;
    }
}