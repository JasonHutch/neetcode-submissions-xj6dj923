public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int left = 0;
        int right = s1.Length;

        if(s2.Length < s1.Length)
        {
            return false;
        }

        while((s2.Length - left) >= s1.Length)
        {
            string currentPerm = s2.Substring(left, s1.Length);
            if(IsPerm(s1,currentPerm))
            {
                return true;
            }
            else
            {
                left+=1;
            }
        }
        return false;
    }

    public bool IsPerm(string s1, string s2)
    {
        string ordered = string.Concat(s1.OrderBy(s => s));
        string ordered2 = string.Concat(s2.OrderBy(s => s));

        return ordered == ordered2;
    }
}
