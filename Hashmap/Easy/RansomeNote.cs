namespace LeetCode.Hashmap.Easy;

public class RansomeNote
{
    public void CheckCanConstruct(){

        // Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

        // Example 1:

        // Input: ransomNote = "a", magazine = "b"
        // Output: false

        // Example 2:

        // Input: ransomNote = "aa", magazine = "ab"
        // Output: false

        // Example 3:

        // Input: ransomNote = "aa", magazine = "aab"
        // Output: true

        string s = "A man, a plan, a canal: Panama";
        string t = "A man, a plan, a canal: Panama";
        Console.WriteLine("Valid Palidrome Result " + CanConstruct(s, t));
    }

    private bool CanConstruct(string ransomNote, string magazine) {
        return false;
    }
}
