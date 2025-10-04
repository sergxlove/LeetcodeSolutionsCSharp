namespace Solutions
{
    public class Solution0011
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int maxArea = 0;
            while (left < right)
            {
                int currentHeight = Math.Min(height[left], height[right]);
                int currentWidth = right - left;
                int currentArea = currentHeight * currentWidth;
                maxArea = Math.Max(maxArea, currentArea);
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return maxArea;
        }
    }
}
