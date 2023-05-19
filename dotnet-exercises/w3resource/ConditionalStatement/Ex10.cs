namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7

Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
*/
public class Ex10 : IRunner
{
    public void Run()
    {
        Console.Write("Enter first number - ");
        var number1 = Convert.ToInt32(Console.ReadLine());
     
        Console.Write("Enter second number - ");
        var number2 = Convert.ToInt32(Console.ReadLine());
 
        Console.Write("Enter third number - ");
        var number3 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Result of specified numbers {0}, {1} and {2}, (x+y)·z is {3} and x·y + y·z is {4}\n\n",
            number1, number2, number3, ((number1+number2)*number3), (number1*number2+number2*number3));
        
    }
}