public class Solution {
    public bool IsPalindrome(int x) {
        string src = x.ToString();
        char[] reverse = src.ToCharArray();
        Array.Reverse(reverse);
        

        if (src == new string(reverse))
            return true;
        return false; 
    }
}