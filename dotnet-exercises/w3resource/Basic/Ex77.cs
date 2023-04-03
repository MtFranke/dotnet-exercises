using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check whether a given word is plural or not.
Sample Output:
Is 'Exercise' is plural? False
Is 'Exercises' is plural? True
Is 'Books' is plural? True
Is 'Book' is plural? False
 */
public class Ex77 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("Exercise"));
        Console.WriteLine(DoAlgorithm("Exercises"));
        Console.WriteLine(DoAlgorithm("Books"));
        Console.WriteLine(DoAlgorithm("Book"));
    }

    [Pure]
    private static bool DoAlgorithm(string input)
        => input.Last() == 's';
}