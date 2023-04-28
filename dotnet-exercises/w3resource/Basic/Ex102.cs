namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to create a identity matrix.
Sample Data:
Input a number: 3
1 0 0
0 1 0
0 0 1
*/
public class Ex102 : IRunner
{
    public void Run()
    {
        DoAlgorithm(3);
    }

    private static void DoAlgorithm(int size)
    {
        int[,] matrix = new int[size, size];

        // Initialize the matrix with 0's
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = 0;
            }
        }
        
        // Set diagonal elements to 1
        for (int i = 0; i < size; i++)
        {
            matrix[i, i] = 1;
        }
        
        // Print the matrix
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}