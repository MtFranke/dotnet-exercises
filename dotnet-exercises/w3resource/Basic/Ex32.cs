using System;
/*
Write a C# program to create a new string of four copies, taking last four characters from a given string.
If the length of the given string is less than 4 return the original one.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
dog.dog.dog.dog.
*/
namespace dotnet_exercises.w3resource.Basic
{
	public class Ex32: IRunner
	{
        public void Run()
        {
            const string input = "The quick brown fox jumps over the lazy dog.";
            if (input.Length < 4) Console.Write(input);
            var last4 = input.Substring(input.Length -4);
            Console.Write("{0}{0}{0}{0}", last4);
        }
    }
}

