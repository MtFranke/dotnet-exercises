using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to find the cumulative sum of an array of number.
A cumulative sum is a sequence of partial sums of a given sequence. 
For example, the cumulative sums of the sequence {x, y, z,...}, are x , x+y , x+y+z

Sample Output:
Orginal Array elements:
1 3 4 5 6 7
Cumulative sum of the said array elements:
1 4 8 13 19 26
Orginal Array elements:
1.2 -3 4.1 6 -5.47
Cumulative sum of the said array elements:
1.2 -1.8 2.3 8.3 2.83
*/
public class Ex85 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{string.Join(", ",DoAlgorithm(new[]{1, 3, 4, 5, 6, 7})) }");
    }

    [Pure]
    private static IEnumerable<int> DoAlgorithm(IList<int> arr)
    {
        var cumulativeSum = 0;
        foreach (var value in arr)
        {
            cumulativeSum += value;
            yield return cumulativeSum;
        }
    }
}