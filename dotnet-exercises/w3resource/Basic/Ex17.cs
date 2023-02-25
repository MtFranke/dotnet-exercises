using System.Text;

namespace dotnet_exercises.w3resource.basic;

/*
Write a C# program to create a new string from a given string (length 1 or more ) with the first character added at the front and back.
Sample Output:
Input a string : The quick brown fox jumps over the lazy dog.
TThe quick brown fox jumps over the lazy dog.T
*/
public class Ex17: IRunner
{
    public void Run()
    { 
        const string input = "The quick brown fox jumps over the lazy dog.";
        var firstLetter = input[0];
        var stringBuilder = new StringBuilder();
        stringBuilder.Append(firstLetter);
        stringBuilder.Append(input);
        stringBuilder.Append(firstLetter);
        Console.WriteLine(stringBuilder.ToString());
    }
}