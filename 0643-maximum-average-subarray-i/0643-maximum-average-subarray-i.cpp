class Solution {
public:
    double findMaxAverage(vector<int>& nums, int k)
    {
        double sum = 0;
        double max = 0;
        int groupsNum = nums.size() - k + 1;
        int pointer = k;

        for(int i = 0; i < k ;i++)
        {
            sum += nums[i];
        }
        
        max = sum;

        if(nums.size()==k)
            return max / k; 

        for(int i = 0; i < groupsNum;i++)
        {
            sum -= nums[i];
            sum += nums[pointer];
            pointer++;

            if(sum > max)
                max = sum;
        }

        return max / (double)k;

    }
};