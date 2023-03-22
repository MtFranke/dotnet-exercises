using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

//Find the minimum value from two given two numbers, represented as string
public class Ex66: IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("22","44"));
    }

    [Pure]
    private static int DoAlgorithm(string input1, string input2)
    {
        int.TryParse(input1, out var num1);
        int.TryParse(input2, out var num2);

        return num1 > num2 ? num2 : num1;
    }
}