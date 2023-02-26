namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
Sample Output:
Odd numbers from 1 to 99. Prints one number per line.
1
3
5
7
9
...
95
97
99 
*/
public class Ex25: IRunner
{
    public void Run()
    {
        for (int i = 1; i <= 99; i++)
        {
            if(i%2==1)
                Console.WriteLine(i);
        }
    }
}