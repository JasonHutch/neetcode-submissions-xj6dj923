// 1,7,2,5,4,7,3,6
//   l
//     r

class Solution {
    public int maxArea(int[] heights) {
        int maxArea = 0;
        int left = 0;
        int right = heights.length - 1;

        while(left < right) {
            int width = right - left;
            int height = Math.min(heights[left], heights[right]);

            maxArea = Math.max(maxArea, width * height);

            if(heights[left] < heights[right]) {
                left++;
            }
            else {
                right--;
            }
        }

        return maxArea;
    }
}
