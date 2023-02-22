namespace dotnet_exercises.w3resource.basic;

/*
Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/
public class Ex10: IRunner
{
    public void Run()
    {
        var (a, b, c) = (5, 6, 7);
        Console.WriteLine($"(x + y) * z = {(a + b) * c} and x * y + y * z = {(a * b) + (b * c)}");
    }
}