public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seen = new();
        int left = 0;
        int right = left + 1;
        int output = 0;

        if(s.Length == 0)
        {
            return output;
        }

        if(s.Length == 1)
        {
            return 1;
        }


        seen.Add(s[left]);

        while(right < s.Length)
        {
            if(seen.Contains(s[right]))
            {
                // Prepare to calc next hash set
                seen.Clear();
                left += 1;
                right = left + 1;
                seen.Add(s[left]);
            }
            else
            {
                seen.Add(s[right]);
                right += 1;
            }
            output = Math.Max(output, seen.Count);
        }
        return output;
    }
}
