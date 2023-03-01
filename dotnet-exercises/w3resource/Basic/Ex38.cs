using System;

/*
Write a C# program to get a new string of two characters from a given string.
The first and second character of the given string must be "P" and "H", so PHP will be "PH".
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex38 : IRunner
    {
        public void Run()
        {
            const string input = "PHP Tutorial";
            if (input.Length >= 2)
            {
                if (input[0] == 'P' && input[1] == 'H') {

                    Console.WriteLine(input[0].ToString() + input[1]);
                }
            }
        }
    }
}

