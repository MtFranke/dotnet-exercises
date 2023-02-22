namespace dotnet_exercises.w3resource.basic;

/*
Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
*/
public class Ex6 : IRunner
{
    public void Run()
    {
        var (a, b, c) = (2, 3, 6);
        Console.WriteLine($"Numbers to multiply {a}, {b}, {c} results in {a * b * c}");
    }
}