namespace dotnet_exercises.w3resource.BasicAlgorithm;

/*
Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
Sample Input:
1, 2
3, 2
2, 2
Expected Output:
3
5
12   
*/
public class Ba_ex1 : IRunner
{
    public void Run()
    {
        DoAlgorithm(1, 2);
        DoAlgorithm(2, 3);
        DoAlgorithm(2, 2);
    }

    private static void DoAlgorithm(int a, int b)
    {
        var result = a == b ? (a + b) * 3 : a + b;
        Console.WriteLine($"Input {a}, {b} - > {result}");
    }
}