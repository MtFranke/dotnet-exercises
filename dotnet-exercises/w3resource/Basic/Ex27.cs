namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program and compute the sum of the digits of an integer.
Sample Output:
Input a number(integer): 12
Sum of the digits of the said integer: 3
*/
public class Ex27: IRunner
{
    public void Run()
    {
        Console.Write("Input a number(integer): ");
        var number = Console.ReadLine();
        int answer = 0;
        foreach (var n in number)
        {
           int.TryParse(n.ToString(),out var parsedNumber);
           answer += parsedNumber;
        }

        Console.WriteLine($"Sum of the digits of the said integer: {answer}");
    }
}