namespace LeetCode.ArrayOrString.Easy;

public class RemoveElement
{
    public void RemoveElementFromArray()
    {
        // Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
        // The remaining elements of nums are not important as well as the size of nums.
        // Return k.

        // Input: nums = [3,2,2,3], val = 3
        // Output: 2, nums = [2,2,_,_]

        // Input: nums = [0,1,2,2,3,0,4,2], val = 2
        // Output: 5, nums = [0,1,4,0,3,_,_,_]

        // int[] nums = new int[] {3,2,2,3};
        // int val = 3;

        // int[] nums = new int[] {0,1,2,2,3,0,4,2};
        // int val = 2;

        int[] nums = new int[] { 2 };
        int val = 3;

        var result = GetRemovedElement(nums, val);
        Console.WriteLine("RemoveElement Result: " + result);
    }

    private int GetRemovedElement(int[] nums, int val)
    {
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] == val)
            {
                nums[i] = 101;
            }
        }

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] == 101)
            {
                for (int j = nums.Length - 1; j > i; j--)
                {
                    if (nums[j] != 101)
                    {
                        nums[i] = nums[j];
                        nums[j] = 101;
                        break;
                    }
                }
            }
        }

        var result = 0;
        for (int i = 0; i <= nums.Length - 1; i++)
        {
            if (nums[i] == 101)
            {
                result = i;
                break;
            }

            if (i == nums.Length - 1)
            {
                result = i + 1;
            }
        }
        return result;
    }

}
