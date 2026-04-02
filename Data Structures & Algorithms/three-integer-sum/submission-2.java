
//-1,-1,-4,0,1,2
//    j
//             k

class Solution {
    public List<List<Integer>> threeSum(int[] nums) {
        Arrays.sort(nums);
        List<List<Integer>> results = new ArrayList<>();

        for(int i = 0; i < nums.length - 2; i++) {

            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = nums.length - 1;

            int target = -(nums[i]);
            

            while(j < k) {
                int currentSum = nums[j] + nums[k];
                if(currentSum > target) {
                    k--;
                }

                if(currentSum < target) {
                    j++;
                }

                if(currentSum == target) {
                    // We found a tripplet, need to save to results
                    List<Integer> triplet = new ArrayList<Integer>();
                    triplet.add(nums[i]);
                    triplet.add(nums[j]);
                    triplet.add(nums[k]);

                    results.add(triplet);

                    // Now that we've found a match, we need to move j and k so that they're on diff indexes
                    int currentj = nums[j];
                    int currentk = nums[k];

                    while(j < nums.length && currentj == nums[j]) {
                        j++;
                    }

                     while(k > 0 && currentk == nums[k]) {
                        k--;
                    }
                }
            }
        }

        return results;
    }
}
