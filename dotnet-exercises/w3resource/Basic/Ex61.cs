using System;
using System.Diagnostics.Contracts;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to sort the integers in ascending order without moving the number -5.
*/
public class Ex61 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{string.Join(", ", DoAlgorithm(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 })) }");
         
    }

    [Pure]
    private static int[] DoAlgorithm(int[] toSortArray) {

        Console.WriteLine(string.Join(", ", toSortArray));
        const int untachableNumber = -5;
        int[] sorted = toSortArray
            .Where(x => x != untachableNumber)
            .OrderBy(x => x)
            .ToArray();

        int ctr = 0;

        var sortedForReq = new int[toSortArray.Length];
                             
        for (int i = 0; i < toSortArray.Length; i++)
        {
            if (toSortArray[i] != untachableNumber)
            {
                sortedForReq[i] = sorted[ctr++];
                continue;
            }


            sortedForReq[i] = untachableNumber;
        }

        return sortedForReq;

    }
}
