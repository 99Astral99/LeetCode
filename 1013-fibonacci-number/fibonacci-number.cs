public class Solution {
    public int Fib(int n) {
        if (n == 0)
            return 0;

        if (n == 1)
            return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            var res = a + b;
            a = b;
            b = res;
        }
        return b;
    }
}