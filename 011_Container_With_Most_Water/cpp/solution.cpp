/*************************************************************************
	> File Name: solution.cpp
# Author: rsq
# mail: rsqmail@163.com
	> Created Time: 三 12/19 19:37:21 2018
 ************************************************************************/
#include<vector>
using namespace std;

class Solution {
public:
    
    int maxArea(vector<int>& height) {
        int result = 0;
        int left = 0;
        int right = height.size()-1;
        
        while(left<right)
        {
            int temp = _AreaSize(left, right, height);
            if(result<temp) result = temp;
            if(height[left]<height[right]) left++;
            else right--;
        }
        
        return result;
    }
private:
    int _AreaSize(int left, int right, vector<int>& height)
    {
        if(height[left]<height[right]) return height[left]*(right-left);
        else return height[right]*(right-left);
    }
};
