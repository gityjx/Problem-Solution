/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/6
 * 时间: 16:04
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Reverse_Bits
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public uint reverseBits(uint n) 
		{
			string bitStr = Convert.ToString(n,2).PadLeft(32, '0');
			char[] inverChar = new char[32];
			int k=0;
			for(int i = bitStr.Length-1;i>=0;i--)
			{
				inverChar[k++] = bitStr[i];
			}
			string inverStr = string.Join("", inverChar);
			return Convert.ToUInt32(inverStr, 2);
			
    	}
	}
}
