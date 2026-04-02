public class Solution {
    public bool IsPalindrome(string s) {
        // One pointer at the begining
        // One pointer at the end

        //if both are valid, compare
        // if left isn't valid move right
        // if right isnt't valid move left

        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            //Ensure left and right are valid
            while(left < right && !Char.IsLetterOrDigit(s[left]))
            {
                left+=1;
            }

            while(left < right && !Char.IsLetterOrDigit(s[right]))
            {
                right-=1;
            }

            if(Char.ToLower(s[left]) != Char.ToLower(s[right]))
            {
                return false;
            }

            left+=1;
            right-=1;
        }
        return true;
    }
}
