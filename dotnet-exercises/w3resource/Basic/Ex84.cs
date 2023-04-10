using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to get the index number of all lower case letters in a given string.
Sample Output:
Orginal string: Python
Indices of all lower case letters of the said string:
1 2 3 4 5
Orginal string: JavaScript
Indices of all lower case letters of the said string:
1 2 3 5 6 7 8 9
 */
public class Ex84 : IRunner
{
    public void Run()
    {
        Console.WriteLine(string.Join(", ", DoAlgorithm("Python")));
        Console.WriteLine(string.Join(", ", DoAlgorithm("JavaScript")));
    }

    [Pure]
    private static int[] DoAlgorithm(string input)
    {
        var lowerCharIndexArr = new List<int>();
        for (var i = 0; i < input.Length; i++) {
            if (Char.IsLower(input[i])) 
                lowerCharIndexArr.Add(i);
        }

        return lowerCharIndexArr.ToArray();
    }
}