public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groupedAnagrams = new Dictionary<string, List<string>>();
        List<List<string>> groups = new List<List<string>>();

        for(int i = 0; i < strs.Length; i++)
        {
            string key = String.Concat(strs[i].OrderBy(c => c));
            string currentValue = strs[i];

            if(groupedAnagrams.ContainsKey(key))
            {
                List<string> currentList = groupedAnagrams[key];
                currentList.Add(currentValue);
            }
            else
            {
                List<string> newList = new List<string>(){ currentValue };
                groupedAnagrams.Add(key,newList);
            }
        }

        foreach(List<string> list in groupedAnagrams.Values)
        {
            groups.Add(list);
        }

        return groups;
    }
}
