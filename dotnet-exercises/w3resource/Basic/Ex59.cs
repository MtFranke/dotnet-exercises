using System;
using System.Diagnostics.Contracts;

/*
Write a C# program to check whether it is possible to create a strictly increasing sequence from a given sequence of integers as an array. 
*/
namespace dotnet_exercises.w3resource.Basic;

public class Ex59 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(new int[] { 1, 3, 1, 3 })}");
        Console.WriteLine($"{DoAlgorithm(new int[] { 1, 3, 5, 6, 9 })}");
        Console.WriteLine($"{DoAlgorithm(new int[] { 0, 10 })}");
    }

    [Pure]
    private static bool DoAlgorithm(int[] sequence) {

        var previousNumber = sequence[0];
        foreach(var number in sequence)
        {
            if (number < previousNumber) return false;
            previousNumber = number;
          
        }
        return true;
    }
}


