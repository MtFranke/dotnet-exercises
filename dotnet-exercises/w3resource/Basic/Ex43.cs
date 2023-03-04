using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to check if a given string starts with "w" and immediately followed by two "ww". Go to the editor
Test Data:
Input a string : www
Sample Output
True 
 */
public class Ex43 : IRunner
{
    public void Run()
    {
        Console.Write("Input a string: ");
        var input = Console.ReadLine();
        Console.WriteLine($"{DoAlgorithm(input)}");
    }

    [Pure]
    private static bool DoAlgorithm(string input)
    {
        const string pattern = "^[w]{3}";
        Regex regex = new Regex(pattern);
        return regex.IsMatch(input);
    }
}