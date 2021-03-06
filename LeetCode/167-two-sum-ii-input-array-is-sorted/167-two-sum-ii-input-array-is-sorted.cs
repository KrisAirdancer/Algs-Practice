public class Solution {
    
    /// <summary>
    /// 
    /// IDEA:
    /// There will always be one solution (never no solution)
    /// Non-decreasing means the numbers get larger as we move from left to right.
    /// Use two pointers, one starting at either end of the array, that move
    /// towards the center of the array. If the sum of the values at the two
    /// pointers is greater than the target int, move the right pionter to
    /// the left. If the sum is less than the target, move the left pointer
    /// to the right. If the sum equals the target, return a new array
    /// containing the indices of the two pointers (each should be incremmented)
    /// by one before being added to the array due to the 1-indexing requirement.
    /// 
    /// COMPLEXITY:
    /// Time: O(N)
    /// Space: O(1)
    /// 
    /// </summary>
    public int[] TwoSum(int[] numbers, int target) {
        
        int left = 0;
        int right = numbers.Length - 1;
        
        while (numbers[left] + numbers[right] != target) {

            if (numbers[left] + numbers[right] < target) { left++; }
            else { right--; } // sum > target
        }

        int[] indices = {left + 1, right + 1};
        return indices;
    }
}