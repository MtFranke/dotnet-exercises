using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to create a new string where the first 4 characters will be in lower case. If the string is less than 4 characters then make the whole string in upper case.
Test Data:
Input a string: w3r
Sample Output
W3R 
*/
public class Ex42 : IRunner
{
    public void Run()
    {
        Console.Write("Input a string: ");
        var input = Console.ReadLine();
        Console.WriteLine($"{DoAlgorithm(input)}");
    }

    
    [Pure]
    private static string DoAlgorithm(string input)
    {
        if (input.Length < 4)
            return input.ToUpper();

        var firstLetters = input.Substring(0, 4).ToLower();
        var rest = input.Substring(4);
        return $"{firstLetters}{rest}";
        
    }
}