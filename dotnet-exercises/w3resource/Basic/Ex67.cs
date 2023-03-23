using System.Diagnostics.Contracts;
using System.Text;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to create a coded string from a given string, using specified formula.
Replace all 'P' with '9', 'T' with '0', 'S' with '1', 'H' with '6' and 'A' with '8'.
Sample Output:
PHP - > 969
JAVASCRIPT -> J8V81CRI90
*/
public class Ex67 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm("PHP")}");
        Console.WriteLine($"{DoAlgorithm("JAVASCRIPT")}");
    }

    [Pure]
    public string DoAlgorithm(string input)
    {
        StringBuilder output = new StringBuilder();
        foreach (var c in input)
        {
            switch (c)
            {
                case 'P':
                    output.Append('9');
                    break;
                
                case 'T':
                    output.Append('0');
                    break;
                
                case 'S':
                    output.Append('1');
                    break;
                
                case 'H':
                    output.Append('6');
                    break;
                
                case 'A':
                    output.Append('8');
                    break;

                default:
                    output.Append(c);
                    break;
            }
        }

        return output.ToString();
    }
    
    
    // public static string DoAlgorithm(string input)
    // {
    //     return input
    //         .Replace("P", "9")
    //         .Replace("T", "0")
    //         .Replace("S", "1")
    //         .Replace("H", "6")
    //         .Replace("A", "8");
    // }
}