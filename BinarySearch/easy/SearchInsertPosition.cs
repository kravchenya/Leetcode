namespace LeetCode.BinarySearch.Easy;

public class SearchInsertPosition
{

    public void Search() {
        // Given a sorted array of distinct integers and a target value, return the index if the target is found. 
        // If not, return the index where it would be if it were inserted in order.

        // You must write an algorithm with O(log n) runtime complexity.

        // Example 1:
        // Input: nums = [1,3,5,6], target = 5
        // Output: 2

        // Example 2:
        // Input: nums = [1,3,5,6], target = 2
        // Output: 1

        // Example 3:
        // Input: nums = [1,3,5,6], target = 7
        // Output: 4

        int[] nums = new int[] { 1, 3, 5, 6 };
        int target = 0;
        Console.WriteLine("Result: " + SearchInsert(nums, target));
    }

    private int SearchInsert(int[] nums, int target) 
    {
        int min = 0;
        int max = nums.Length - 1;
        int middle = 0;
        while (min <= max) {
            
            middle = min + (max - min) / 2;

            if (nums[middle] == target) {
                return middle;
            }

            if (nums[middle] < target) {
                min = middle + 1;
            }
            if (nums[middle] > target) {
                max = middle - 1;
            }
        }

        return nums[middle] < target ? middle + 1: middle;
    }
}