using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check if a given string (floating point and negative numbers included) is numeric or not. 
Return True if the said string is numeric otherwise false. 
Sample Data:
("123") -> True
("123.33") -> True
("33/33") -> False
("234234d2") -> False
*/
public class Ex97: IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("123"));
        Console.WriteLine(DoAlgorithm("123.33"));
        Console.WriteLine(DoAlgorithm("33/33"));
        Console.WriteLine(DoAlgorithm("234234d2"));
    }

    [Pure]
    private static bool DoAlgorithm(string input)
    {
        var numericRegex = new Regex("^[0-9.]+$");
        return numericRegex.IsMatch(input);
    }
}