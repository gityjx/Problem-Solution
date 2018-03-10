/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/6
 * 时间: 15:26
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Number_of_1_Bits
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public int HammingWeight(uint n)
    	{
    		string bitStr = Convert.ToString(n,2);
    		int count = 0;
    		foreach(char bitChar in bitStr)
    		{
    			if(bitChar == '1')
    			{
    				count++;
    			}
    		}
    		return count;
    	}
	}
}
