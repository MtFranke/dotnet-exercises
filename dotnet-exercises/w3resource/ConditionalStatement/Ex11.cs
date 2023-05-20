namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to calculate the root of a quadratic equation.
Test Data :
Input the value of a : 1
Input the value of b : 5
Input the value of c : 7
Expected Output :
Root are imaginary;
No Solution.
 */
public class Ex11 : IRunner
{
    public void Run()
    {
        double d, x1,x2;
        Console.Write("\n\n");
        Console.Write("Calculate root of Quadratic Equation :\n");
        Console.Write("----------------------------------------");
        Console.Write("\n\n");
 
        Console.Write("Input the value of a : ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of b : ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the value of c : ");
        var c = Convert.ToInt32(Console.ReadLine());

        d=b*b-4*a*c;
        
        switch (d)
        {
            case 0:
                Console.Write("Both roots are equal.\n");
                x1=-b/(2.0*a);
                x2=x1;
                Console.Write("First  Root Root1= {0}\n",x1);
                Console.Write("Second Root Root2= {0}\n",x2);
                break;
            case > 0:
                Console.Write("Both roots are real and diff-2\n");

                x1=(-b+Math.Sqrt(d))/(2*a);
                x2=(-b-Math.Sqrt(d))/(2*a);

                Console.Write("First  Root Root1= {0}\n",x1);
                Console.Write("Second Root root2= {0}\n",x2);
                break;
            default:
                Console.Write("Root are imeainary;\nNo Solution. \n\n");
                break;
        }

    }
}