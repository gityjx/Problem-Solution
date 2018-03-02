/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/2/28
 * 时间: 14:31
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Hamming_Distance
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int HammingDistance(int x, int y) 
		{
			int maxLen = Convert.ToString((System.Int64)Math.Pow(2,31), 2).Length;
			string xbina = Convert.ToString(x,2).PadLeft(maxLen, '0');
			string ybina = Convert.ToString(y,2).PadLeft(maxLen, '0');
			int count =0;
			for(int i=0;i<maxLen;i++)
			{
				if(xbina[i] != ybina[i])
					++count;
			}
			return count;
		}
	}
}
