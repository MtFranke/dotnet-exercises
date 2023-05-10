namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
Test Data : -5
Expected Output:
The value of n = -1
 */
public class Ex6 : IRunner
{
    public void Run()
    {
        int m, n;
        Console.Write("Input the  value of m :");
        m = Convert.ToInt32(Console.ReadLine());
        if (m != 0)
            if (m > 0)
                n = 1;
            else
                n = -1;
        else
            n = 0;
        Console.Write("The value of m = {0} \n", m);
        Console.Write("The value of n = {0} \n\n", n);
    }
}