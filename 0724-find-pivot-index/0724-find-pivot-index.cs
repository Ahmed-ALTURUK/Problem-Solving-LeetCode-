public class Solution {
    public int PivotIndex(int[] nums) {
       
        int[] letfSumArr = new int[nums.Length];
        int[] RightSumArr = new int[nums.Length];

       for(int i = 0; i < nums.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

          
            int left = 0;
            int right = nums.Length - 1;

            while(left < i)
            {
                leftSum += nums[left];
                left++;
            }

            while(right > i)
            {
                rightSum += nums[right];
                right--;
            }

            letfSumArr[i] = leftSum;
            RightSumArr[i] = rightSum;
        }

        for(int j = 0; j < nums.Length; j++)
        {
            if(letfSumArr[j] == RightSumArr[j]) return j;

        }

        return -1;
    }
}