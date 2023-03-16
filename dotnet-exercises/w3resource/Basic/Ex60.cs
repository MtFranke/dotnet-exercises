using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to calculate the sum of all the integers of a rectangular matrix except those integers which are located below an intger of value 0.
Sample Example:
matrix = [
[0, 2, 3, 2],
[0, 6, 0, 1],
[4, 0, 3, 0]
]
Eligible integers which will be participated to calculate the sum -
matrix = [
[X, 2, 3, 2],
[X, 6, X, 1],
[X, X, X, X]
]
Therefore sum will be: 2 + 3 + 2 + 6 + 1 = 14
 
 */
public class Ex60 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm
            (
                new int[][]
                {
                    new int[] { 0, 2, 3, 2 },
                    new int[] { 0, 6, 0, 1 },
                    new int[] { 4, 0, 3, 0 } }
            )
        }");
    }

    [Pure]
    private static int DoAlgorithm(int[][] matrix)
    {
        var sum = 0;
        for (var i = 0; i < matrix.Length; i++)
        {
            for (var j = 0; j < matrix[i].Length; j++)
            {
                if (i == 0 || matrix[i - 1][j] != 0)
                {
                    Console.WriteLine(matrix[i][j]);
                    sum += matrix[i][j];
                }
            }
        }

        return sum;
    }
}