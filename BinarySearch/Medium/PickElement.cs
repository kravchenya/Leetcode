namespace LeetCode.BinarySearch.Medium;

public class PickElement
{
    public void  GetPeakElement() {

        // Given a 0-indexed integer array nums, find a peak element, and return its index. If the array contains multiple peaks, return the index to any of the peaks.

        // Example 1:
        // Input: nums = [1,2,3,1]
        // Output: 2
        // Explanation: 3 is a peak element and your function should return the index number 2.

        // Example 2:
        // Input: nums = [1,2,1,3,5,6,4]
        // Output: 5
        // Explanation: Your function can return either index number 1 where the peak element is 2, or index number 5 where the peak element is 6.

        int[] nums = new int[] { 1,2,1,2,1 };
        Console.WriteLine("Pick is " + FindPeakElement(nums));
    }

    private int FindPeakElement(int[] nums) {

        if (nums.Length == 1) 
            return nums[0];
        if (nums[0] >= nums[1])
            return nums[0];
        if (nums[nums.Length - 1] >= nums[nums.Length - 2])
            return nums[nums.Length - 1];

        int left = 1;
        int right = nums.Length - 2;
        int median = 0;
        while (left <= right)
        {
            median = left + (right - left) / 2;
            
            if (nums[median] > nums[median -1] && nums[median] > nums[median + 1]) {
                return median;
            }

            if (nums[median] < nums[median + 1]){
                left = median + 1; 
            } else
            // caused false positive by { 1,2,1,2,1 } and m[2] = 1; this is a local minimum for right and left
            // if (nums[median] < nums[median - 1])
            {
                right = median - 1; 
            }
        }
        return median;
    }
}
