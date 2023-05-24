namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.
Test Data :
50 50 60
Expected Output :
This is an isosceles triangle.
*/
public class Ex14 : IRunner
{
    public void Run()
    {
        int sidea, sideb, sidec;
        Console.Write("\n\n");
        Console.Write("Check whether a triangle is Equilateral, Isosceles or Scalene:\n");
        Console.Write("----------------------------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input side 1 of triangle: ");
        sidea = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input side 2 of triangle: ");
        sideb = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input side 3 of triangle: ");
        sidec = Convert.ToInt32(Console.ReadLine());


        if (sidea == sideb && sideb == sidec)
        {
            Console.Write("This is an equilateral triangle.\n");
        }
        else if (sidea == sideb || sidea == sidec || sideb == sidec)
        {
            Console.Write("This is an isosceles triangle.\n");
        }
        else
        {
            Console.Write("This is a scalene triangle.\n");
        }
    }
}