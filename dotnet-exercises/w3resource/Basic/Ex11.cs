namespace dotnet_exercises.w3resource.basic;

/*
Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20". Go to the editor
Test Data:
Enter your age - 25
Expected Output:
You look older than 25
*/
public class Ex11 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Enter your age: ");
        var input = Console.ReadLine();
        var age = int.Parse(input);
        Console.WriteLine($"You look older than {age}");
    }
}