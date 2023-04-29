using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to sort characters in a given string (uppercase/lowercase letters and numbers).
Return the new sorted string.
Sample Data:
("AAAbfed231") -> "AAAbdef123"
(" ") -> "Blank string!"
("Python") -> "hnoPty"
("W3resource") -> "ceeorrsuW3"
*/
public class Ex103: IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("Python"));
        Console.WriteLine(DoAlgorithm("W3resource"));
        Console.WriteLine(DoAlgorithm("AAAbfed231"));
        Console.WriteLine(DoAlgorithm(" "));
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        bool flag = string.IsNullOrWhiteSpace(input);
        if (flag)
            return "Blank string!";
        
        var text_nums = input.Where(char.IsDigit).OrderBy(el => el).ToList();
        var text_chars = input.Where(char.IsLetter)
            .Select(el => new { l_char = char.ToLower(el), _char = el })
            .OrderBy(el => el.l_char)
            .ThenByDescending(el => el._char)
            .ToList();

        return new string(text_chars.Select(el => el._char).Concat(text_nums).ToArray());

    }
}