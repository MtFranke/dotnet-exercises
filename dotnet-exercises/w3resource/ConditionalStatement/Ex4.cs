namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Test Data : 2016
Expected Output :
2016 is a leap year.
*/
public class Ex4: IRunner
{
    public void Run()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
            Console.WriteLine($"{year} is a leap year.");
        } else Console.WriteLine($"{year} is not a leap year.");
        
    }
}