using System.Text.RegularExpressions;

namespace LeetCode.TwoPointers.Easy;

public class ValidPalindrome
{
    public void CheckIfPalidrome()
    {
        // Given a string s, return true if it is a palindrome, or false otherwise.
        
        // Example 1:

        // Input: s = "A man, a plan, a canal: Panama"
        // Output: true
        // Explanation: "amanaplanacanalpanama" is a palindrome.

        // Example 2:

        // Input: s = "race a car"
        // Output: false
        // Explanation: "raceacar" is not a palindrome.

        // Example 3:

        // Input: s = " "
        // Output: true
        // Explanation: s is an empty string "" after removing non-alphanumeric characters.
        // Since an empty string reads the same forward and backward, it is a palindrome.

        // string s = "race a car";
        string s = "A man, a plan, a canal: Panama";
        Console.WriteLine("Valid Palidrome Result " + IsPalindrome(s));
    }
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        s = Regex.Replace( s, @"[^A-Za-z0-9]+", "");
        var n = s.Length;
        for (int i = 0; i < n / 2; i++)
        {
            if (s[i] != s[n - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}
