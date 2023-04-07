using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to swap a two digit given number and check whether the given number is greater than its swap value.
Sample Output:
Input an integer value:
Check whether the said value is greater than its swap value: True
 */
public class Ex81: IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(12));
        Console.WriteLine(DoAlgorithm(28));
        Console.WriteLine(DoAlgorithm(81));
        
    }

    [Pure]
    private static bool DoAlgorithm(int num)
    {
        var onesDigit = (int) num / 10;
        var tensDigit = num % 10;
        int swappedNum = (tensDigit * 10) + onesDigit;
        return num >= swappedNum;
    }
}