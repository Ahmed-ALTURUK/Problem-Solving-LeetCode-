public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
    
        int greatestNum = 0;
        bool[] result = new bool[candies.Length];

        for(int i = 0; i < candies.Length;i++)
        {
            greatestNum = candies[i] + extraCandies;

            for(int j = 0; j < candies.Length;j++)
            {
                if(candies[j] > greatestNum)
                {
                 result[i] = false;
                 break;
                }
                else
                 result[i] = true;
            }
        }

        return result;
    }
}