using System.Diagnostics.Contracts;
using System.Net.Mime;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
If the string already begins with 'if', return the string unchanged.
Sample Input:
"if else"
"else"
Expected Output:
if else
if else
*/
public class BAEx5 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"if else -> {DoAlgorithm("if else")}");
        Console.WriteLine($"else ->  {DoAlgorithm("else")}");
    }

    [Pure]
    private static string DoAlgorithm(string txt)
    {
        const string startString = "if";
        return txt.StartsWith(startString) ? txt : $"{startString} {txt}";
    }
}