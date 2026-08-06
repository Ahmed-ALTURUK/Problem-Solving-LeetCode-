public class Solution {

    //The time complextiy of this function is O(n)
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        
       int maxCandies = 0;
        for (int i = 0; i < candies.Length; i++) {
            if (candies[i] > maxCandies) {
                maxCandies = candies[i];
            }
        }

        bool[] result = new bool[candies.Length];

        for (int i = 0; i < candies.Length; i++) 
        {
            result[i] = (candies[i] + extraCandies) >= maxCandies;
        }

        return result;

        return result;
    }
}