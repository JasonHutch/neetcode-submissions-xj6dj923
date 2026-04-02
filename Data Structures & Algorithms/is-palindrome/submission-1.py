class Solution:
    def isPalindrome(self, s: str) -> bool:
        lowered_string = s.lower()
        left = 0
        right = len(lowered_string) - 1

        while left < right:

            # Need to see if these are alpha numberic first
            while (left < right) and not lowered_string[left].isalnum():
                left += 1
            
            while (left < right) and not lowered_string[right].isalnum():
                right -= 1

            if lowered_string[left] != lowered_string[right]:
                return False

            left += 1
            right -= 1
        return True