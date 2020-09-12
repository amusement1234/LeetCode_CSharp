/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 *
 * https://leetcode-cn.com/problems/3sum/description/
 *
 * algorithms
 * Medium (29.11%)
 * Likes:    2507
 * Dislikes: 0
 * Total Accepted:    305.6K
 * Total Submissions: 1M
 * Testcase Example:  '[-1,0,1,2,-1,-4]'
 *
 * 给你一个包含 n 个整数的数组 nums，判断 nums 中是否存在三个元素 a，b，c ，使得 a + b + c = 0
 * ？请你找出所有满足条件且不重复的三元组。
 * 
 * 注意：答案中不可以包含重复的三元组。
 * 
 * 
 * 
 * 示例：
 * 
 * 给定数组 nums = [-1, 0, 1, 2, -1, -4]，
 * 
 * 满足要求的三元组集合为：
 * [
 * ⁠ [-1, 0, 1],
 * ⁠ [-1, -1, 2]
 * ]
 * 
 * 
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        // 解法1：暴力法
        IList<IList<int>> arr = new List<IList<int>>();
        if (nums == null || nums.Length < 3)
            return arr;

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var temp = new int[3] { nums[i], nums[j], nums[k] };
                        Array.Sort(temp);
                        arr.Add(temp.ToList());
                    }
                }
            }
        }        
        var arr2 = arr.GroupBy(x => string.Join(",", x), (g, items) => items.First()).ToList();//去重
        return arr2;


        // 解法2：双指针法
        List<IList<int>> arr = new List<IList<int>>();
        if (nums == null || nums.Length < 3)
            return arr;

        Array.Sort(nums);// 排序

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                break;

            if (i > 0 && nums[i] == nums[i - 1])
                continue; // 去重

            int start = i + 1;
            int end = nums.Length - 1;
            while (start < end)
            {
                int sum = nums[i] + nums[start] + nums[end];
                if (sum < 0)
                    start++;
                else if (sum > 0)
                    end--;
                else if (sum == 0)
                {
                    List<int> tempList = new List<int>() { nums[i], nums[start], nums[end] };
                    arr.Add(tempList);

                    while (start < end && nums[start] == nums[start + 1])
                        start++; // 去重
                    while (start < end && nums[end] == nums[end - 1])
                        end--; // 去重

                    start++;
                    end--;
                }
            }
        }
        return arr;

        // 解法3：双指针法（简化版）
        Array.Sort(nums);
        IList<IList<int>> res = new List<IList<int>>();
        for (int i = 0; i < nums.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))
            {
                int start = i + 1, end = nums.Length - 1, sum = 0 - nums[i];
                while (start < end)
                {
                    if (nums[start] + nums[end] == sum)
                    {
                        res.Add(new List<int>() { nums[i], nums[start], nums[end] });

                        while (start < end && nums[start] == nums[start + 1]) start++;
                        while (start < end && nums[end] == nums[end - 1]) end--;

                        start++; end--;
                    }
                    else if (nums[start] + nums[end] < sum) start++;
                    else end--;
                }
            }
        }
        return res;

    }
}
// @lc code=end

