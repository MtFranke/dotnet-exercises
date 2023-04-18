using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to find the next prime number of a given number. If the given number is a prime number, return the number.
From Wikipedia,
A prime number (or a prime) is a natural number greater than 1 that is not a product of two smaller natural numbers. 
A natural number greater than 1 that is not prime is called a composite number.
For example, 5 is prime because the only ways of writing it as a product, 1 × 5 or 5 × 1, involve 5 itself. However, 4 is composite because it is a product (2 × 2) in which both numbers are smaller than 4.
Primes are central in number theory because of the fundamental theorem of arithmetic: 
every natural number greater than 1 is either a prime itself or can be factorized as a product of primes that is unique up to their order.
Sample Output:
Original number: 120
Next prime number/Current prime number: 127
Original number: 321
Next prime number/Current prime number: 331
Original number: 43
Next prime number/Current prime number: 43
Original number: 4433
Next prime number/Current prime number: 4441
*/
public class Ex92 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm(120));
        Console.WriteLine(DoAlgorithm(321));
        Console.WriteLine(DoAlgorithm(43));
        Console.WriteLine(DoAlgorithm(4433));
    }

    [Pure]
    private static int DoAlgorithm(int number)
    {
        var nextNumber = number;
        while (!IsPrime(nextNumber))
        {
            nextNumber++;
        }

        return nextNumber;
    }
    
    private static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}