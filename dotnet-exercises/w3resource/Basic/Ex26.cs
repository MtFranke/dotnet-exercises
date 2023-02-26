using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to compute the sum of the first 500 prime numbers.
Sample Output:
Sum of the first 500 prime numbers:
824693 
*/
public class Ex26 : IRunner
{
    public void Run()
    {
    
        Console.WriteLine(DoAlgorithm());
    }

    [Pure]
    private static int DoAlgorithm()
    {
        var sum = 0;
        var primeNumberCount = 0;
        var i = 0;

        while (primeNumberCount != 500)
        {
            if (IsPrime(i))
            {
                sum += i;
                primeNumberCount++;
            }
            i++;
        }

        return sum;

        [Pure]
        static bool IsPrime( int n)
        {
            if (n < 2)
            {
                return false;
            }
        
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
        
            return true;
        }
    }
    
}