public class Solution {
    public bool IsSubsequence(string s, string t) {
        int i = 0;
        int j = 0;

        for(;i < s.Length && j < t.Length;j++)
        {
            if(s[i] == t[j])
            {
                i++;
            }
        }
        return (i == s.Length);
       
    }
}