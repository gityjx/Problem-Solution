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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Solution So = new Solution();
			int[] inputArray = new int[]{1,2,3};
			IList<IList<int>> result= So.Subsets(inputArray);
			Console.WriteLine(result.Count);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}