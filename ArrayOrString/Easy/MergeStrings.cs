namespace LeetCode.ArrayOrString.Easy;

public class MergeStrings
{
    public void DoMergeStrings()
    {
         // You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1. 
        // If a string is longer than the other, append the additional letters onto the end of the merged string.

        // Input: word1 = "abc", word2 = "pqr"
        // Output: "apbqcr"

        // Input: word1 = "ab", word2 = "pqrs"
        // Output: "apbqrs"

        // Input: word1 = "abcd", word2 = "pq"
        // Output: "apbqcd"

        var result = MergeStringsAlternatively("abc", "pqr");
        Console.WriteLine("MergeStrings Result: " + result);
    }

    private string MergeStringsAlternatively(string word1, string word2)
    {
        string result = "";
        for (int i = 0; i <= word1.Length - 1; i ++){
            if (i > word2.Length - 1) {
                result = result + word1.Substring(i);
                break;    
            }
            if (i == word1.Length - 1 &&  i <= word2.Length - 1 ) {
                 result = result + word1[i] +  word2.Substring(i);
                break;    
            }
            result = result + word1[i] + word2[i];
        }
        return result;
    }
}
