using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to get the ASCII value of a given character.
Sample Output:
Ascii value of 1 is: 49
Ascii value of A is: 65
Ascii value of a is: 97
Ascii value of # is: 35
 */
public class Ex76 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm('1'));
        Console.WriteLine(DoAlgorithm('A'));
        Console.WriteLine(DoAlgorithm('a'));
        Console.WriteLine(DoAlgorithm('#'));
    }

    [Pure]
    private static int DoAlgorithm(char character)
        => character;
    
}