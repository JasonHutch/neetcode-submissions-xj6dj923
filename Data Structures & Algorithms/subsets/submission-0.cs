public class Solution {
    public List<List<int>> Subsets(int[] nums) {

        List<List<int>> result = new List<List<int>>();

        BackTrack(nums, new List<int>(), 0, result);

        return result;

    }

    public void BackTrack(int[] nums, List<int>path, int currentLevel, List<List<int>> result)
    {
        if(currentLevel == nums.Length)
        {
            result.Add(new List<int>(path));
            return;
        }

        // Recurison + Backtracking

        // Explore adding a specific number
        path.Add(nums[currentLevel]);
        BackTrack(nums, path, currentLevel+1, result);

        // Once that path is explored, undo the decision and explore that specific path
        path.RemoveAt(path.Count - 1);
        BackTrack(nums, path, currentLevel + 1, result);
    }
}
