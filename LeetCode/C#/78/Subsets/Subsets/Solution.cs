/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/5
 * 时间: 15:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Subsets
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public IList<IList<int>> Subsets(int[] nums) 
		{
        	int maxLen =1<< nums.Length;
        	IList<IList<int>> result = new List<IList<int>>();

        	for(int ele=0;ele<maxLen;ele++)
        	{
        		char[] idx = Convert.ToString(ele,2).PadLeft(nums.Length,'0').ToCharArray();
        		IList<int> subset = new List<int>();
        		for(int i=0;i<idx.Length;i++)
        		{
        			if(idx[i]=='1')
        			{
        				subset.Add(nums[i]);
        			}
        		}
				result.Add(subset);
        		
        	}
        	
        	return result;
    	}
	}
}
