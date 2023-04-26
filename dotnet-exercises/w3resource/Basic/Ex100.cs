using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
100. Write a C# Sharp program to check the equality comparison (value and type ) of two parameters.
Return true if they are equal otherwise false. 
Sample Data:
("AAA", "BBB") -> False
(true, false) -> False
(true, "true") -> False
(10, 10) -> True
 */
public class Ex100 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("AAA","BBB"));
        Console.WriteLine(DoAlgorithm(true,false));
        Console.WriteLine(DoAlgorithm(true,"true"));
        Console.WriteLine(DoAlgorithm(10,10));
    }

    [Pure]
    private static bool DoAlgorithm(object x, object y)
    {
        if (!x.Equals(y))
        {
            return false;
        }

        return x.GetType() == y.GetType();
    }

}