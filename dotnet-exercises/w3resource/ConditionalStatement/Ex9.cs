namespace dotnet_exercises.w3resource.ConditionalStatement;

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
public class Ex9 : IRunner
{
    public void Run()
    {
        Console.Write("Enter the First number: ");
        var number1 = Convert.ToDouble(Console.ReadLine());
 
        Console.Write("Enter the Second number: ");
        var number2 = Convert.ToDouble(Console.ReadLine());
 
        Console.Write("Enter the third number: ");
        var number3 = Convert.ToDouble(Console.ReadLine());
 
        Console.Write("Enter the fourth number: ");
        var number4 = Convert.ToDouble(Console.ReadLine());

        var arr = new List<Double> { number1, number2, number3, number4 };
        Console.WriteLine($"Average is {arr.Average()}");
    }
}