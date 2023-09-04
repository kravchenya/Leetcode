namespace LeetCode.TwoPointers.Easy;

public class SubSequence
{

    public void CheckIfSubstring()
    {
        // Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

        // Example 1:

        // Input: s = "abc", t = "ahbgdc"
        // Output: true

        // Example 2:

        // Input: s = "axc", t = "ahbgdc"
        // Output: false

        string s = "acb";
        string t = "ahbgdc";
        Console.WriteLine("Subsequence Result " + IsSubsequenceBad(s, t));
    }


    private bool IsSubsequenceBad(string s, string t)
    {
        int n = 0;
        int m = 0;
        var result = true;

        if (s.Length == 0)
        {
            result = true;
        }

        if (s.Length != 0 && t.Length == 0)
        {
            result = false;
        }

        while (n <= s.Length - 1 && m <= t.Length - 1)
        {
            if (m == t.Length - 1 && (s[n] != t[m] || n < s.Length -1))
            {
                return false;
            }

            if (s[n] == t[m])
            {
                n++;
                m++;
                continue;
            }

            if (s[n] != t[m])
            {
                m++;
                continue;
            }
        }

        return result;
    }

    public bool isSubsequenceImproved(string s, string t) {
        var n = s.Length;
        var m = t.Length;
        var pLeft = 0;
        var pRight = 0;

        while (pLeft < n && pRight < m) {
            // move both pointers or just the right pointer
            if (s[pLeft] == t[pRight]) {
                pLeft += 1;
            }
            pRight += 1;
        }
        return pLeft == n;
    }

}
