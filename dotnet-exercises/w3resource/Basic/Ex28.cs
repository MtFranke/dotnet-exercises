namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to reverse the words of a sentence.
Sample Output:
Original String: Display the pattern like pyramid using the alphabet.
Reverse String: alphabet. the using pyramid like pattern the Display
*/
public class Ex28 : IRunner
{
    public void Run()
    {
        const string input = "Display the pattern like pyramid using the alphabet.";
        var reversed = input.Split(" ").Reverse();
        var reversedInput = string.Join(" ", reversed);
        Console.WriteLine($"Original String: {input}");
        Console.WriteLine($"Reverse String: {reversedInput}");
    }
}