using System.Diagnostics.Contracts;
using System.Text;

namespace dotnet_exercises.w3resource.Basic;

/*Write a C# program to reverse the strings contained in each pair of matching parentheses in a given string and also remove the parentheses within the given string.*/
public class Ex62: IRunner
{
    public void Run()
    {
        Console.WriteLine($"p(rq)st -> {DoAlgorithm("p(rq)st")}");
        Console.WriteLine($"(p(rq)st) -> {DoAlgorithm("(p(rq)st)")}");
        Console.WriteLine($"ab(cd(ef)gh)ij -> {DoAlgorithm("ab(cd(ef)gh)ij")}");
    }

    [Pure]
    private static string DoAlgorithm(string input)
    {
        if (string.IsNullOrEmpty(input)) return input;
        
        var openIndices = new Stack<int>();
        var closeIndices = new Queue<int>();
        var nests = 0;
        var answer = new StringBuilder(input);
        for (var i = 0; i < input.Length; i++)
        {
            if (input[i] == '(') openIndices.Push(i);
            if (input[i] == ')') closeIndices.Enqueue(i);
            
        }

        if (openIndices.Count == closeIndices.Count)
            nests = openIndices.Count;

        for (int i = 0; i < nests; i++)
        {
            var startIndex = openIndices.Pop();
            var endIndex = closeIndices.Dequeue();
            var scope = answer.ToString().Substring(startIndex, endIndex - startIndex +1);
            var reversed = string.Join("",  scope.Reverse());
            answer.Replace(scope, reversed);
        }
        
        return answer.ToString().Replace("(","").Replace(")","");
    }
}
