using System.Diagnostics.Contracts;

namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# programme to check the said string is valid or not.
The input string will be valid when open brackets and closed brackets are same type of brackets 
Or open brackets will be closed in proper order.
Sample Data:
( "<>") -> True
("<>()[]{}”) -> True
("(<>”) -> False
("[<>()[]{}]”) -> True
*/
public class Ex95 : IRunner
{
    public void Run()
    {
        Console.WriteLine(DoAlgorithm("<>"));
        Console.WriteLine(DoAlgorithm("<>()[]{}"));
        Console.WriteLine(DoAlgorithm("(<>"));
        Console.WriteLine(DoAlgorithm("[<>()[]{}]"));
    }

    [Pure]
    private static bool DoAlgorithm(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();
                if ((top == '(' && c != ')') || (top == '[' && c != ']') || (top == '{' && c != '}'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}