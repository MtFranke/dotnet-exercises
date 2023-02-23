using System.Diagnostics.Contracts;
using System.Text;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
If the given string length is less than 2 return the original string.
Sample Input:
"C Sharp"
"JS"
"a"
Expected Output:

C C C C 
JSJSJSJS
a
*/
public class BAEx8 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"C Sharp -> {DoAlgorithm("C Sharp")}");
        Console.WriteLine($"JS -> {DoAlgorithm("JS")}");
        Console.WriteLine($"a -> {DoAlgorithm("a")}");
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        if (input.Length < 2)
            return input;
            
        var frontCharacters = input.Substring(0, 2);
        var result = new StringBuilder();
        for (var i = 0; i < 4; i++)
            result.Append(frontCharacters);
        
        return result.ToString();
    }
}