namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit. 
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86
*/
public class Ex14 : IRunner
{
    public void Run()
    {
        Console.Write("Enter the amount of celsius: ");
        int.TryParse(Console.ReadLine(), out var n);
        var kelvin = n + 273.15;
        var fahrenheit = (n * 1.8) + 32;
        Console.WriteLine($"Kelvin -> {kelvin}K");
        Console.WriteLine($"Fahrenheit -> {fahrenheit}°F");
        
    }
}