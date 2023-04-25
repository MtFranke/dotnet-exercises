namespace dotnet_exercises.w3resource.Basic;

public class Ex99 : IRunner
{
    public void Run()
    {
        DoAlgorithm();
    }

    private static void DoAlgorithm()
    {
        for (int i = 2; i <= 1000; i++) {
            if (IsPrime(i) && IsAscending(i)) {
                Console.Write(i + ", ");
            }
        }

    }

    static bool IsPrime(int number) {
        if (number <= 1) {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) {
                return false;
            }
        }

        return true;
    }

    static bool IsAscending(int number) {
        int lastDigit = number % 10;
        number /= 10;

        while (number > 0) {
            int digit = number % 10;
            if (digit >= lastDigit) {
                return false;
            }
            lastDigit = digit;
            number /= 10;
        }

        return true;
    }
}