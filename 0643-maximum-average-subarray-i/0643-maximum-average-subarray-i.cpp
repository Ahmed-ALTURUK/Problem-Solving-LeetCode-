class Solution {
public:
    double findMaxAverage(vector<int>& nums, int k)
    {
        int sum = 0;
        int maxSum = 0;
       
        for(int i = 0; i < k ;i++)
        {
            sum += nums[i];
        }
        
        maxSum = sum;

        if(nums.size()==k)
            return (double) maxSum / k; 

        for(int i = k; i < nums.size();i++)
        {
            sum = sum - nums[i - k] + nums[i];
            maxSum = max(maxSum, sum);
        }

        return (double) maxSum / k;

    }
};