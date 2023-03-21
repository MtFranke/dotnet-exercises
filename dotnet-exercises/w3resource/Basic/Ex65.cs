namespace dotnet_exercises.w3resource.Basic;

//Write a C# Sharp program to multiply all of elements of a given array of numbers by the array length.
public class Ex65: IRunner
{
    public void Run()
    {
        int[] nums = { 1, 3, 5, 7, 9 };
        var multiply = nums.Select(x => x * nums.Length).ToArray();
        Console.WriteLine(string.Join(", ", multiply));
    }
}