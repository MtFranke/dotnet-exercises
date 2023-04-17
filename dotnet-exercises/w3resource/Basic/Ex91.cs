namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to remove all the values except integer values from a given array of mixed values.
Sample Output:
Original array elements:
25 Anna False 4/24/2021 11:43:11 AM -112 -34.67
After removing all the values except integer values from the said array of mixed values: 25 -112
*/
public class Ex91 : IRunner
{
    public void Run()
    {
        object[] mixedArray = new object[6];
        mixedArray[0] = 25;
        mixedArray[1] = "Anna";
        mixedArray[2] = false;
        mixedArray[3] = System.DateTime.Now;
        mixedArray[4] = -112;
        mixedArray[4] = -112;
        mixedArray[5] = -34.67;
        
        Console.WriteLine(string.Join(", ", mixedArray));

        var filtered = mixedArray.OfType<int>();
        
        Console.WriteLine(string.Join(", ", filtered));
    }
}