/*
 * @lc app=leetcode.cn id=11 lang=csharp
 *
 * [11] 盛最多水的容器
 *
 * https://leetcode-cn.com/problems/container-with-most-water/description/
 *
 * algorithms
 * Medium (63.90%)
 * Likes:    1763
 * Dislikes: 0
 * Total Accepted:    267K
 * Total Submissions: 417.2K
 * Testcase Example:  '[1,8,6,2,5,4,8,3,7]'
 *
 * 给你 n 个非负整数 a1，a2，...，an，每个数代表坐标中的一个点 (i, ai) 。在坐标内画 n 条垂直线，垂直线 i 的两个端点分别为
 * (i, ai) 和 (i, 0)。找出其中的两条线，使得它们与 x 轴共同构成的容器可以容纳最多的水。
 * 
 * 说明：你不能倾斜容器，且 n 的值至少为 2。
 * 
 * 
 * 
 * 
 * 
 * 图中垂直线代表输入数组 [1,8,6,2,5,4,8,3,7]。在此情况下，容器能够容纳水（表示为蓝色部分）的最大值为 49。
 * 
 * 
 * 
 * 示例：
 * 
 * 输入：[1,8,6,2,5,4,8,3,7]
 * 输出：49
 * 
 */

// @lc code=start
public class Solution
{
    public int MaxArea(int[] height)
    {
        // 解法1：暴力
        int res = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                int thisArea = (j - i) * Math.Min(height[i], height[j]);
                res = Math.Max(res, thisArea);
            }
        }
        return res;

        // // 解法2：双指针
        // int res = 0;
        // int left = 0; int right = height.Length - 1;
        // while (left < right)
        // {
        //     int thisArea = (right - left) * Math.Min(height[left], height[right]);
        //     res = Math.Max(res, thisArea);
        //     if (height[left] > height[right]) right--;
        //     else left++;
        // }
        // return res;

        // // 解法3：双指针优化
        // int res = 0;
        // int left = 0; int right = height.Length - 1;
        // while (left < right)
        // {
        //     int minHeight = Math.Min(height[left], height[right]);
        //     int thisArea = (right - left) * minHeight;
        //     res = Math.Max(res, thisArea);
        //     if (left < right && height[left] <= minHeight) left++;
        //     if (left < right && height[right] <= minHeight) right--;
        // }
        // return res;


    }
}
// @lc code=end

