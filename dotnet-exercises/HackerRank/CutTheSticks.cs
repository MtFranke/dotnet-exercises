using System.Diagnostics.Contracts;

namespace dotnet_exercises.HackerRank;

//https://www.hackerrank.com/challenges/cut-the-sticks/problem?isFullScreen=true
public class CutTheSticks : IRunner
{
    public void Run()
    {
        Console.WriteLine(string.Join(", ", DoAlgorithm( new List<int> {5, 4, 4, 2, 2, 8})) );
        Console.WriteLine(string.Join(", ", DoAlgorithm( new List<int>{1,2,3})) );
        Console.WriteLine(string.Join(", ", DoAlgorithm( new List<int>{8, 8 ,14, 10, 3, 5, 14, 12})) );
    }

    [Pure]
    private static List<int> DoAlgorithm(List<int> arr)
    {
        List<int> answer = new List<int> {arr.Count};

  
        arr.Sort();
        var lastSlice = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            var number = arr[i] - lastSlice;
            if(number <= 0)
                continue;
            
            var counter = 0;
            for (int j = i; j < arr.Count; j++)
            {
                var pickedNumber = arr[j] - lastSlice;
                var calc = pickedNumber - number;
                if (0 >= calc)
                {
                    counter++;
                }
            }

            lastSlice = number + lastSlice;
            var lastAdded = answer.Last();
            answer.Add(lastAdded - counter);

            if (lastAdded - counter <= 1)
            {
                break;
                
            }
        }

        answer.RemoveAll(x => x == 0);
        return answer;
    }
    
}