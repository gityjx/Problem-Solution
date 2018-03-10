/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/5
 * 时间: 12:54
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Sum_of_Two_Integers
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int GetSum(int a, int b) 
		{
//			int flag = 1;
//			if(a*b < 0)
//			{
//				flag = -flag;
//				if(a<0)
//					a = -a;
//				else
//					b = -b;
//			}
			if (b == 0)
				return a;
        	int sumPar = a^b;
        	int carryPar  = (a&b)<<1;
        	return GetSum(sumPar,carryPar);
    	}
	}
}
