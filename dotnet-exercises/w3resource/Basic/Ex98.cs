using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to create and display all prime numbers in strictly descending decimal digit order.
Sample Data:
2, 3, 5, 7, 31, 41, 43, 53, 61, 71, 73, 83, 97, 421, 431.....
*/
public class Ex98 : IRunner
{
    
    public void Run()
    {
        DoAlgorithm();
    }

    private static void DoAlgorithm()
    {
        int limit = 10000;
        for (int i = 2; i < limit; i++) {
            if (IsPrime(i) && IsDescending(i)) {
                Console.Write(i + ", ");
            }
        }

    }

    static bool IsPrime(int n) {
        if (n <= 1) {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++) {
            if (n % i == 0) {
                return false;
            }
        }
        return true;
    }
    
    static bool IsDescending(int n) {
        int prevDigit = 10;
        while (n > 0) {
            int currDigit = n % 10;
            if (currDigit >= prevDigit) {
                return false;
            }
            prevDigit = currDigit;
            n /= 10;
        }
        return true;
    }
}