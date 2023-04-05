using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to convert an integer to string and a string to an integer.
Sample Output:
Original value and type: 50, System.String
Convert string to integer:
Return value and type: 50, System.Int32
Original value and type: 122, System.Int32
Convert integer to string:
Return value and type: 122, System.String
 */
public class Ex79 : IRunner
{
    public void Run()
    {
        var result1 = DoAlgorithm("50");
        Console.WriteLine($"Casted -> {result1}, {result1.GetType()}");
        
        var result2 = DoAlgorithm(50);
        Console.WriteLine($"Casted -> {result2}, {result2.GetType()}");

    }

    [Pure]
    public static object DoAlgorithm(object obj)
    {
        object newObject = null;
        Console.WriteLine($"Original -> {obj}, {obj.GetType()}");
        newObject = obj switch
        {
            string s => int.Parse(s),
            int i => i.ToString(),
            _ => newObject
        };

        return newObject;
    }
}