namespace dotnet_exercises.other;

public static class ReversNumber
{
    public static int Revers(this int number)
    {
        var reversed = 0;

        while (number != 0)
        {
            var remaining = number % 10;
            reversed = reversed * 10 + remaining;
            number /= 10;
        }

        return reversed;
    }
}