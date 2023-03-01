using System;

/*
Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP".
Test Data: PHP Tutorial
Sample Output:
P Tutorial 
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex37 : IRunner
    {
        public void Run()
        {
            const string searchedWord = "HP";
            const string input = "PHP Tutorial";
            var s = input.Substring(1, 2) == searchedWord ? input.Remove(1, 2) : input;
            Console.WriteLine(s);
        }
    }
}

