using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check whether all the characters in a string are the same. 
Return true if all the characters in the said string are same otherwise false
Sample Data:
("aaa") -> True
("abcd") -> False
("3333") -> True
("2342342") -> False
*/
public class Ex96 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("aaa"));
        Console.WriteLine(DoAlgorithm("abcd"));
        Console.WriteLine(DoAlgorithm("3333"));
        Console.WriteLine(DoAlgorithm("2342342"));
    }

    [Pure]
    private static bool DoAlgorithm(string input) 
        => input.Distinct().Count() == 1;
    
}