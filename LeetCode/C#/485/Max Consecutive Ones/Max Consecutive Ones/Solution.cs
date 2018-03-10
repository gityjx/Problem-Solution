/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 16:34
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Max_Consecutive_Ones
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int FindMaxConsecutiveOnes(int[] nums) 
		{
			List<int> lstIdx = new List<int>();
			lstIdx.Add(-1);
			for(int i=0;i<nums.Length;i++)
			{
				if(nums[i]==0)
					lstIdx.Add(i);
			}
			lstIdx.Add(nums.Length);
			int[] lenArray =new int[lstIdx.Count];
			for(int i=1;i<lstIdx.Count;i++)
			{
				lenArray[i-1] = lstIdx[i]-lstIdx[i-1];
			}
			int maxLen = 0;
			for(int i=0;i<lenArray.Length;i++)
			{
				if(lenArray[i] > maxLen)
					maxLen = lenArray[i];
			}
			return maxLen-;
			
    	}
	}
}
