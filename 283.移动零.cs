/*
 * @lc app=leetcode.cn id=283 lang=csharp
 *
 * [283] 移动零
 *
 * https://leetcode-cn.com/problems/move-zeroes/description/
 *
 * algorithms
 * Easy (62.05%)
 * Likes:    703
 * Dislikes: 0
 * Total Accepted:    195K
 * Total Submissions: 314.3K
 * Testcase Example:  '[0,1,0,3,12]'
 *
 * 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
 * 
 * 示例:
 * 
 * 输入: [0,1,0,3,12]
 * 输出: [1,3,12,0,0]
 * 
 * 说明:
 * 
 * 
 * 必须在原数组上操作，不能拷贝额外的数组。
 * 尽量减少操作次数。
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // 解法1：处理不为0的，再处理为0的
        if (nums == null || nums.Length == 0)
            return;
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                nums[index++] = nums[i];
        }
        while (index < nums.Length)
        {
            nums[index++] = 0;
        }

        // // 解法2：遇到不为0的，互换位置
        // int j = 0;
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] != 0)
        //     {
        //         int temp = nums[i];
        //         nums[i] = nums[j];
        //         nums[j] = temp;
        //         j++;
        //     }
        // }

    }
}
// @lc code=end

