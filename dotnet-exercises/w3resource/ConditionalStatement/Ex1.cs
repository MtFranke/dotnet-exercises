namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to accept two integers and check whether they are equal or not.
Test Data :
Input 1st number: 5
Input 2nd number: 5
Expected Output :
5 and 5 are equal
*/
public class Ex1: IRunner
{
    public void Run()
    {
        Console.WriteLine("Input 1st number: ");
        int.TryParse(Console.ReadLine(), out var n1);
        
        Console.WriteLine("Input 2nd number: ");
        int.TryParse(Console.ReadLine(), out var n2);

        var equality = n1 == n2 ? "equal" : "not equal";
        Console.WriteLine($"{n1} and {n2} are {equality}");
    }
}