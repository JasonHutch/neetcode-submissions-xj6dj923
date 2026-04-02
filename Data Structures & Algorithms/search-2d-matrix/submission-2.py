class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:
        # How many total rows do I have?
        top = 0
        bottom = len(matrix) - 1

        while top <= bottom:
            mid = (top + bottom) // 2

            current_row = matrix[mid]
            for val in current_row:
                if val == target:
                    return True
            
            ## value is not in the current row
            if target > current_row[-1]:
                # val is potentially in later rows
                top = mid + 1
            else:
                bottom = mid - 1

        return False
