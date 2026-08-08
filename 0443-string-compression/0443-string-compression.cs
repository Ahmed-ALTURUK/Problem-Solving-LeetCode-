public class Solution {
    public int Compress(char[] chars) {
        
        int write = 0;
        int read = 0;

        while(read < chars.Length)
        {   
            char currentChar = chars[read];
            int count = 0;

            while(read < chars.Length && currentChar == chars[read])
            {
                read++;
                count++;
            }

            chars[write] = currentChar;
            write++;

            if(count > 1)
            {
                foreach(char c in count.ToString())
                {
                    chars[write] = c;
                    write++;
                }
            }
        }
        return write;
    }
}