using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# program that finds the longest common prefix from an array of strings.
Sample Data:
({ "Padas", "Packed", "Pace", "Pacha" }) -> "Pa"
({ "Jacket", "Joint", "Junky", "Jet" }) -> "J"
({ "Bort", "Whang", "Yarder", "Zoonic" }) -> ""
*/
public class Ex94 : IRunner
{
    public void Run()
    {
        Console.WriteLine($"{DoAlgorithm(new[]{"Padas", "Packed", "Pace", "Pacha" })}");
        Console.WriteLine($"{DoAlgorithm(new[]{"Jacket", "Joint", "Junky", "Jet"  })}");
        Console.WriteLine($"{DoAlgorithm(new[]{"Bort", "Whang", "Yarder", "Zoonic" })}");
    }

    [Pure]
    private static string DoAlgorithm(IList<string> words)
    {
        if (words == null || words.Count == 0)
            return "";

        for (int i = 0; i < words[0].Length; i++)
        {
            char c = words[0][i];
            for (int j = 1; j < words.Count; j++)
            {
                if (i == words[j].Length || words[j][i] != c)
                    return words[0].Substring(0, i);
            }
        }

        return words[0];
    }
}