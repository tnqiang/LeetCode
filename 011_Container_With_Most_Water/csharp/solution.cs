
public class Solution {
    private int getArea(int left, int right, int[] height)
    {
        if(height[left]<height[right])
        {
            return (right-left)*height[left];
        }
        else
        {
            return (right-left)*height[right];            
        }
    }
    public int MaxArea(int[] height) {
        int result = 0;
        int left = 0;
        int right = height.Length-1;
        
        while(left < right)
        {
            int temp = getArea(left, right, height);
            if(result < temp)
            {
                result = temp;
            }
            if(height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;                
            }
        }
        
        return result;
    }
}
