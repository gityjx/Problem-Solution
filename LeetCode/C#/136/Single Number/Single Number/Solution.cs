/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 17:19
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Single_Number
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int SingleNumber(int[] nums) 
		{
        	int a = 0;
        	foreach(int i in nums)
        		a ^= i;	
        	return a;
        		
    	}
	}
}
