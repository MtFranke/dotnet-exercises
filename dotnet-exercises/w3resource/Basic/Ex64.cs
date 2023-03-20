namespace dotnet_exercises.w3resource.Basic;

//Write a C# Sharp program to get the file name (including extension) from a given path.
public class Ex64 : IRunner
{
    public void Run()
    {
        const string path = "dotnet-exercises/w3resource/Basic/Ex64.cs";
        FileInfo info = new FileInfo(path);
        Console.WriteLine(info.Name);
    }
}