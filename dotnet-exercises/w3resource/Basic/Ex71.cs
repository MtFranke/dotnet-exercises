using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to check if a given string contains two similar consecutive letters.
Sample Output:
Original string: PHP
Test for consecutive similar letters! False
Original string: PHHP
Test for consecutive similar letters! True
Original string: PHPP
Test for consecutive similar letters! True
Original string: PPHP
Test for consecutive similar letters! True
*/
public class Ex71 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("PHP"));
        Console.WriteLine(DoAlgorithm("PHHP"));
        Console.WriteLine(DoAlgorithm("PHPP"));
        Console.WriteLine(DoAlgorithm("PPHP"));
    }

    [Pure]
    private static bool DoAlgorithm(string input)
    {
        for (int i = 0; i < input.Length - 1; i++) {
            if (input[i] == input[i + 1]) {
                return true;
            }
        }

        return false;
    }
}