namespace dotnet_exercises.w3resource.Basic;

/*
Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
Sample Output:
Printing original array elements and their types:
Value-> 25 :: Type-> System.Int32
Value-> Anna :: Type-> System.String
Value-> False :: Type-> System.Boolean
Value-> 4/15/2021 10:37:47 AM :: Type-> System.DateTime
Value-> 112.22 :: Type-> System.Double
Printing array elements and their types:
Value-> 25 :: Type-> System.String
Value-> Anna :: Type-> System.String
Value-> False :: Type-> System.String
Value-> 4/15/2021 10:37:47 AM :: Type-> System.String
Value-> 112.22 :: Type-> System.String
 */
public class Ex80 : IRunner
{
    public void Run()
    {
        var mixedArray = new object[5];
        mixedArray[0] = 25;
        mixedArray[1] = "Anna";
        mixedArray[2] = false;
        mixedArray[3] = System.DateTime.Now;
        mixedArray[4] = 112.22;

        foreach (var obj in mixedArray)
        {
            var stringValue = obj.ToString();
            Console.WriteLine($"{stringValue}, {stringValue.GetType()}");
        }
    }
}