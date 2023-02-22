namespace dotnet_exercises.w3resource.basic;

/*
Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18
*/
public class Ex9: IRunner
{
    public void Run()
    {
        var (a, b, c, d) = (10, 15, 20, 30);
        Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {(a + b + c + d)/4}");
        
    }
}