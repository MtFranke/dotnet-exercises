using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to convert the letters of a given string (same case-upper/lower) into alphabetical order.
Sample Output:
Original string: PHP
Convert the letters of the said string into alphabetical order: HPP
Original string: javascript
Convert the letters of the said string into alphabetical order: aacijprstv
Original string: python
Convert the letters of the said string into alphabetical order: hnopty
 */
public class Ex73 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("PHP"));
        Console.WriteLine(DoAlgorithm("javascript"));
        Console.WriteLine(DoAlgorithm("python"));
    }

    // [Pure]
    // private static string DoAlgorithm(string input)
    //     => string.Join(string.Empty, input.OrderBy(x => x));

    [Pure]
    private static string DoAlgorithm(string input)
        => new(input.OrderBy(x => x).ToArray());

}