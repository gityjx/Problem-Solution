/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/5
 * 时间: 14:22
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Majority_Element
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int MajorityElement(int[] nums) 
		{
			Array.Sort(nums);
			return nums[nums.Length/2];
				
    	}
	}
}
