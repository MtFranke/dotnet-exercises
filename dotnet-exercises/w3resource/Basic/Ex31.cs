namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to multiply corresponding elements of two arrays of integers.
Sample Output:
Array1: [1, 3, -5, 4]
Array2: [1, 4, -5, -2]
Multiply corresponding elements of two arrays:
1 12 25 -8
*/
public class Ex31 : IRunner
{
    public void Run()
    {
        var arr1 = new[] { 1, 3, -5, 4 };
        var arr2 = new[] { 1, 4, -5, -2 };
        for (int i = 0; i < arr1.Length; i++)
        {
          Console.Write(arr1[i]*arr2[i]+ " ");
        }
    }
}