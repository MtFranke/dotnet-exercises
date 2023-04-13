using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to reverse a boolean value. Go to the editor
Sample Output:
Original value: False
Reverse value: True
Original value: True
Reverse value: False
*/

public class Ex87 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(false));
        Console.WriteLine(DoAlgorithm(true));
    }

    [Pure]
    private static bool DoAlgorithm(bool flag)
        => flag != true;

}