namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program to check if a number appears as either the first or last element of an array of integers and the length is 1 or more.
*/
public class Ex46 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };

        Console.WriteLine($"{arr[0] == n || arr[^1] == n}");
    }
}