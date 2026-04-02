public class Solution {
    public bool IsAnagram(string s, string t) {
        string orderedS = string.Concat(s.OrderBy(c => c));
        string orderedT = string.Concat(t.OrderBy(c => c));

        return orderedS == orderedT;
    }
}
