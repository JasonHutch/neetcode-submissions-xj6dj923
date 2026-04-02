public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // Iterate through the array and track number and thier occurances in a dictionary

        Dictionary<int, int> dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++)
        {
            int currentValue = nums[i];
            if(dict.ContainsKey(currentValue))
            {
                dict[currentValue] =  dict[currentValue] + 1;
            }
            else
            {
                dict.Add(currentValue, 1);
            }
        }

        int[] result = dict
            .OrderByDescending(pair => pair.Value)
            .Take(k)
            .Select(pair => pair.Key)
            .ToArray();

        return result;
    }
}
