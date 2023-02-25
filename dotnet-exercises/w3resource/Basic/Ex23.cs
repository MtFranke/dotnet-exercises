namespace dotnet_exercises.w3resource.basic;

/*
 Write a C# program to convert a given string into lowercase.
*/
public class Ex23 : IRunner
{
    public void Run()
    {
        const string input = "Hello There My Friend.";
        Console.WriteLine($"{input}{Environment.NewLine}{input.ToLower()}");
    }
}