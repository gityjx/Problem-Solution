/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/2
 * 时间: 18:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace House_Robber
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public int Rob(int[] nums) 
    	{
    		int sum1 = 0;
    		int sum2 = 0;
    		for(int i=0;i<nums.Length;i++)
    		{
    			if(i%2 == 0)
    			{
    				sum1 += nums[i];
    			}
    			else
    			{
    				sum2 += nums[i];
    			}
    		}
    		return sum1 > sum2? sum1:sum2;
    	}
	}
}
