namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given Polygon.
Input number of straight line(s).
From Wikipedia,
In geometry, a polygon is a plane figure that is described by a finite number of straight line segments connected to form a closed polygonal chain or polygonal circuit. The solid plane region, the bounding circuit, or the two together, may be called a Polygon.
Sample Output:
Input number of straight lines of the polygon:
Sum of the interior angles (in degrees) of the said polygon: -360
 */
public class Ex88 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Input number of straight lines of the polygon:");
        int.TryParse(Console.ReadLine(), out var n) ;
        Console.WriteLine(180 * (n - 2));
    }
}