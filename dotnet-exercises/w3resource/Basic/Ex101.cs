namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to calculate the value of e.
Note: e is also known as Euler's number and Napier's constant
Sample Data:
e = 2.718281828459050
 */
public class Ex101 : IRunner
{
    public void Run()
    {
        var n = 20; // number of terms to use in the series
        var e = 1.0; // initialize e to the first term of the series
        
        for (int i = 1; i <= n; i++) {
            double term = 1.0;
            for (int j = i; j >= 1; j--) {
                term *= 1.0 / j;
            }
            e += term;
        }

        Console.WriteLine("The value of e is: {0}", e);
    }
}