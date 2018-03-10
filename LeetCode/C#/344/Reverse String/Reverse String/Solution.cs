/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 17:55
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Text;

namespace Reverse_String
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution 
	{
    	public string ReverseString(string s) 
    	{
    		StringBuilder str = new StringBuilder();
    		for(int i =s.Length-1;i>=0;i--)
    		{
    			str.Append(s[i]);
    		}
    		return str.ToString(;
    	}
	}
}
