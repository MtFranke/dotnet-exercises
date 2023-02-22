namespace dotnet_exercises.w3resource.basic;
/// <summary>
/// Write a C# Sharp program to print Hello and your name in a separate line.
///Expected Output :
///Hello: Alexandra Abramov
/// </summary>

public class Ex1: IRunner
{
    public void Run()
        => Console.Write($"Hello{Environment.NewLine}Mateusz Franke");
    
}