namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.
*/
public class Ex7: IRunner
{
    public void Run()
    {
        Console.Write("Input the height of the person (in centimetres):");
        var perHeight = Convert.ToInt32(Console.ReadLine());
 
        string heightCategory = perHeight < 150.0 ? "Dwarf" :
            perHeight <= 165.0 ? "Average heighted" :
            perHeight <= 195.0 ? "Taller" :
            "Abnormal height";
        
        Console.WriteLine(heightCategory);

    }
}