public class Solution {
    public bool BuddyStrings(string s, string goal) {
             if (s.Length!=goal.Length || s.Length<2) return false;
        int pos = -1;

        for (int i=0; i<s.Length; i++) {
            if (s[i]!=goal[i] && pos == -1) { pos = i; continue;}
            if (s[i]!=goal[i] && pos>=0) {
                if (s[pos]==goal[i] && s[i]==goal[pos]) pos = -2;
                else return false;
                continue;
            }
            if (s[i]!=goal[i]) return false;
        }
        if (pos==-2) return true;
        if (pos>0) return false;
        var hs = new HashSet<char>(s);
        return (hs.Count<s.Length) ? true : false;
    }
}