namespace LeetCode.Hashmap.Easy;

public class RansomeNote
{
    public void CheckCanConstruct()
    {

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

        string ransomNote = "aa";
        string magazine = "aab";
        Console.WriteLine("CanConstruct Result " + CanConstruct(ransomNote, magazine));
    }

    private bool CanConstruct(string ransomNote, string magazine)
    {

        Dictionary<char, int> ransomD = new Dictionary<char, int>();
        Dictionary<char, int> magazineD = new Dictionary<char, int>();

        for (int i = 0; i <= ransomNote.Length -1; i++)
        {
            if (!ransomD.ContainsKey(ransomNote[i]))
            {
                ransomD.Add(ransomNote[i], 1);
            }
            else
            {
                ransomD[ransomNote[i]] = ransomD[ransomNote[i]] + 1;
            }
        }

        for (int i = 0; i <= magazine.Length -1; i++)
        {
            if (!magazineD.ContainsKey(magazine[i]))
            {
                magazineD.Add(magazine[i], 1);
            }
            else
            {
                magazineD[magazine[i]] = magazineD[magazine[i]] + 1;
            }
        }

        foreach (var rD in ransomD)
        {
            if (!magazineD.ContainsKey(rD.Key))
            {
                return false;
            }
            else if (rD.Value > magazineD[rD.Key])
            {
                return false;
            }
        }

        return true;
    }
}
