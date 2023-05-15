using System.Collections;

namespace dotnet_exercises.w3resource.ConditionalStatement;
/*
Write a C# Sharp program to find the largest of three numbers.
Test Data :
Input the 1st number :25
Input the 2nd number :63
Input the 3rd number :10
Expected Output :
The 2nd Number is the greatest among three

 */
public class Ex8 : IRunner
{
    public void Run()
    {
        Console.Write("Input the 1st number :");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        var num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        var num3 = Convert.ToInt32(Console.ReadLine());

        var arr = new Dictionary<string, int>
        {
            {"1st", num1},
            {"2nd", num2},
            {"3th", num3}
        };

        var rec = arr.MaxBy(x=>x.Value);
        Console.WriteLine($"The {rec.Key} Number is the greatest among three");
    }
}