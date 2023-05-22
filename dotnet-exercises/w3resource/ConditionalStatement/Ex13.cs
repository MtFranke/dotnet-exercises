namespace dotnet_exercises.w3resource.ConditionalStatement;

/*
Write a C# Sharp program to read temperature in centigrade and display a suitable message according to the temperature state below:
Temp < 0 then Freezing weather
Temp 0-10 then Very Cold weather
Temp 10-20 then Cold weather
Temp 20-30 then Normal in Temp
Temp 30-40 then Its Hot
Temp >=40 then Its Very Hot
Test Data :
42
Expected Output :
Its very hot.
 */
public class Ex13 : IRunner
{
    public void Run()
    {
        Console.WriteLine("Enter the temperature in centigrade: ");
        int temperature = Convert.ToInt32(Console.ReadLine());

        Dictionary<Func<int, bool>, string> temperatureRanges = new Dictionary<Func<int, bool>, string>()
        {
            { temp => temp < 0, "Freezing weather" },
            { temp => temp >= 0 && temp <= 10, "Very Cold weather" },
            { temp => temp > 10 && temp <= 20, "Cold weather" },
            { temp => temp > 20 && temp <= 30, "Normal in Temp" },
            { temp => temp > 30 && temp <= 40, "It's Hot" },
            { temp => temp > 40, "It's Very Hot" }
        };

        string message = "Temperature state not found";
        foreach (var temperatureRange in temperatureRanges)
        {
            if (temperatureRange.Key.Invoke(temperature))
            {
                message = temperatureRange.Value;
                break;
            }
        }

        Console.WriteLine(message);

    }
}