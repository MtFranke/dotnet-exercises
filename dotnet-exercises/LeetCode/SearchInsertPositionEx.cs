namespace dotnet_exercises.LeetCode;

public class SearchInsertPositionEx : IRunner
{
    public int SearchInsert(int[] nums, int target)
    {
        int i = 0;
        while (i < nums.Length && nums[i] < target) {
            i++;
        }
        return i;

    }

    public void Run()
    {
        SearchInsert(new[]{ 1,3,5,6}, 5);
        SearchInsert(new[]{ 1,3,5,6}, 2);
    }
}