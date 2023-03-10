using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Write a C# program to get the century from a year.
public class Ex54: IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(2000));
    }

    [Pure]
    private static int DoAlgorithm(int year)
    {   
        var century = year / 100;
        if (year % 100 != 0)
            century++;
        
        return century;
    }
}