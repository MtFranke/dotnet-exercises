namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
Test Data : 21
Expected Output:
Congratulation! You are eligible for casting your vote.
 */
public class Ex5 : IRunner
{
    public void Run()
    {
        int.TryParse(Console.ReadLine(), out var n);
        if (n < 18)
        {
            Console.Write("Sorry, You are not eligible to caste your vote.\n");
            Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - n);
        }
        else
            Console.Write("Congratulation! You are eligible for casting your vote.\n\n");
    }
}