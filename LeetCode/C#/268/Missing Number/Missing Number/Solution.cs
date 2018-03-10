/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/5
 * 时间: 14:33
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Missing_Number
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public int MissingNumber(int[] nums) 
    	{
    		Array.Sort(nums);
    		int i = 0;
    		for(i = 0;i<nums.Length;i++)
    		{
    			if(nums[i] != i)
    				return i;
    		}
    		return i;
    	}
	}
}
