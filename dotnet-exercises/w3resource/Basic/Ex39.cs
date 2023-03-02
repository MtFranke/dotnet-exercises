using System;

/*
Write a C# program to find the largest and lowest values from three integer values. Go to the editor
Test Data:
Input first integer:
15
Input second integer:
25
Input third integer:
30
Sample Output
Largest of three: 30
Lowest of three: 15 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex39 : IRunner
    {
        public void Run()
        {
            var arr = new List<int>();
            Console.Write("Input first integer: ");
            arr.Add(int.Parse(Console.ReadLine()));
            Console.Write("Input second integer: ");
            arr.Add(int.Parse(Console.ReadLine()));
            Console.Write("Input thrid integer: ");
            arr.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine($"Largest out of three: {arr.Max()}");
            Console.WriteLine($"Lowest out of three: {arr.Min()}");

        }
    }
}

