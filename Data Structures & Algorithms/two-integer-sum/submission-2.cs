public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Iterate through the array and store the compliment of each number
        // Need to map values to index so that I can return both

        Dictionary<int, int> compliments = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int compliment = target - nums[i];

            if(compliments.ContainsKey(compliment))
            {
                int complimentIndex = compliments[compliment];
                int min = Math.Min(complimentIndex, i);
                int max = Math.Max(complimentIndex, i);

                return new int[]{ min, max };
            }
            compliments[nums[i]] = i;
        }

        return Array.Empty<int>();
    }
}
