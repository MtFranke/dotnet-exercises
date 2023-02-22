using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to remove the character in a given position of a given string.
The given position will be in the range 0.. string length -1 inclusive.
Sample Input:
"Python", 1
"Python", o
"Python", 4
Expected Output:
Pthon
ython
Pythn
*/
public class BAEx6 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"1 -> {DoAlgorithm(1)}");
        Console.WriteLine($"0 -> {DoAlgorithm(0)}");
        Console.WriteLine($"4 -> {DoAlgorithm(4)}");
    }

    [Pure]
    private static string DoAlgorithm(int position)
    {
        const string text = "Python";
        return text.Remove(position, 1);
    }
}