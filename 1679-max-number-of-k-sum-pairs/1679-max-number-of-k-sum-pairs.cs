public class Solution {
    public int MaxOperations(int[] nums, int k) {
        int left = 0;
        int right = nums.Length - 1;
        int maxOperation = 0;
        
        Array.Sort(nums);

        while (left < right) {
            int sum = nums[left] + nums[right];
            
            if (sum == k) {
                maxOperation++;
                left++;
                right--;
            }
            else if (sum > k) {
                right--;
            }
            else {
                left++;  
            }
        }
        
        return maxOperation;
    }
}