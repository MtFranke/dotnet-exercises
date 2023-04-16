namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to count number of ones and zeros in the binary representation of a given integer. Go to the editor
Sample Output:
Original number: 12
Number of ones and zeros in the binary representation of the said number:
Number of ones: 2
Number of zeros: 2
Original number: 1234
Number of ones and zeros in the binary representation of the said number:
Number of ones: 5
Number of zeros: 6
*/
public class Ex90 : IRunner
{
    public void Run()
    {
        DoAlgorithm(12);
        DoAlgorithm(1234);
    }

    private static void DoAlgorithm(int number)
    {
        var binary = Convert.ToString(number, 2);
        Console.WriteLine($"Number of ones: {binary.Count(x => x == '1')}");
        Console.WriteLine($"Number of zeros: {binary.Count(x => x == '0')}");
    }

}