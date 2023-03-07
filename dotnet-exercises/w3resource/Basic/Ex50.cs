using System;

/*
Write a C# program to rotate an array (length 3) of integers in left direction.
Test Data:
Array1: [1, 2, 8]
After rotating array becomes: [2, 8, 1] 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex50 : IRunner
    {
        public void Run()
        {
            var nums = new[] { 1, 2, 8 };
            Console.WriteLine("Before rotating array [{0}]", string.Join(", ", nums));

            var q = new Queue<int>(nums);
            var dequed = q.Dequeue();
            q.Enqueue(dequed);

            Console.WriteLine("After rotating array becomes: [{0}]", string.Join(", ", q));          
        }
    }
}

