public class Solution {
    public int MaxArea(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxWater = 0;

        while (left < right)
        {
            int width = right - left;
            int minHeight = Math.Min(height[left], height[right]);
            int currentArea = width * minHeight;

            maxWater = Math.Max(maxWater, currentArea);
            // Move the pointer with smaller height
            if (height[left] < height[right]){
                left++;
            }
            else{
                right--;
            }
        }
        return maxWater;
    }
}