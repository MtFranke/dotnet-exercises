namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
 */
public class Ex12 : IRunner
{
    public void Run()
    {
        double rl, phy, che, ca, total, per;
        string nm, div;

        Console.WriteLine("\n\nCalculate the total, percentage, and division based on the marks of three subjects:\n");
        Console.WriteLine("-------------------------------------------------------------------------------\n");

        Console.Write("Input the Roll Number of the student: ");
        rl = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input the Name of the Student: ");
        nm = Console.ReadLine();

        Console.Write("Input the marks of Physics: ");
        phy = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the marks of Chemistry: ");
        che = Convert.ToDouble(Console.ReadLine());
        Console.Write("Input the marks of Computer Application: ");
        ca = Convert.ToDouble(Console.ReadLine());

        total = phy + che + ca;
        per = total / 3.0;

        if (per >= 60)
        {
            div = "First";
        }
        else if (per >= 48)
        {
            div = "Second";
        }
        else if (per >= 36)
        {
            div = "Pass";
        }
        else
        {
            div = "Fail";
        }

        Console.WriteLine("\nRoll No: {0}\nName of Student: {1}\n", rl, nm);
        Console.WriteLine("Marks in Physics: {0}\nMarks in Chemistry: {1}\nMarks in Computer Application: {2}\n", phy, che, ca);
        Console.WriteLine("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);
    }
}