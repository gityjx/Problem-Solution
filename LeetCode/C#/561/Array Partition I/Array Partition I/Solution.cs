/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/1
 * 时间: 20:36
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Array_Partition_I
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{

		public int ArrayPairSum(int[] nums) 
		{
			Array.Sort(nums);
			int sum = 0;
			for(int i=0;i<nums.Length; i+=2)
			{
				sum +=nums[i];
			}
			return sum;
		}
	}
}
