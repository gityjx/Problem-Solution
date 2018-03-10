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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int a = -1,b = 1;
			Solution So = new Solution();
			int result = So.GetSum(a,b);
			Console.WriteLine(result);
			Console.WriteLine(-2^2);
			Console.WriteLine((-2&2)<<1);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}