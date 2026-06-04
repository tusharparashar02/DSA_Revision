public class Solution {
    public int[] Decrypt(int[] code, int k) {
        int n = code.Length;
        int[] result = new int[n];

        // Case 1: k == 0
        if (k == 0) return result;

        int windowSum = 0;
        int start, end;

        // Case 2: k > 0 (sum of next k elements)
        if (k > 0)
        {
            start = 1;
            end = k;
            for (int i = start; i <= end; i++)
                windowSum += code[i % n];
            for (int i = 0; i < n; i++)
            {
                result[i] = windowSum;
                windowSum -= code[(i + 1) % n];
                windowSum += code[(i + k + 1) % n];
            }
        }
        else // Case 3: k < 0 (sum of previous |k| elements)
        {
            k = -k;
            start = n - k;
            end = n - 1;
            for (int i = start; i <= end; i++)
                windowSum += code[i];
            for (int i = 0; i < n; i++)
            {
                result[i] = windowSum;
                windowSum -= code[(i - k + n) % n];
                windowSum += code[i % n];
            }
        }
        return result;
    }
}