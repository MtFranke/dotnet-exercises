namespace dotnet_exercises.LeetCode;

public class Solution2 : IRunner
{
    public int SearchInsert(int[] nums, int target)
    {
        var collection = nums.ToList();
        var index = collection.IndexOf(target);
        if (index == -1) return index;

        for (int i = 0; i < nums.Length; i++)
        {
        }

        return -1;

    }

    public void Run()
    {
        SearchInsert(new[]{ 1,3,5,6}, 5);
    }
}