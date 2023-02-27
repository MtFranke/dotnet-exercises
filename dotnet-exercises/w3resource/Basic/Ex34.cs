using System;

/*
Write a C# program to check if a string starts with a specified word. Go to the editor
Note: Suppose the sentence starts with "Hello"
Sample Data: string1 = "Hello how are you?"
Result: Hello.
Sample Output:
Input a string : Hello how are you?
True
*/
namespace dotnet_exercises.w3resource.Basic
{
    public class Ex34 : IRunner
    {
        public void Run()
        {
            const string input = "Hello how are you?";
            const string searchedWord = "Hello";
            var splitWords = input.Split(" ");
            Console.WriteLine(splitWords[0] == searchedWord);


        }
    }
}

