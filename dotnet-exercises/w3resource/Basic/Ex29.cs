namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to find the size of a specified file in bytes.
Sample Output:
Size of a file: 31 
 */
public class Ex29 : IRunner
{
    public void Run()
    {
        var f = new FileInfo("/home/abc.txt");
        Console.WriteLine("Size of a file: " + f.Length);
    }
}