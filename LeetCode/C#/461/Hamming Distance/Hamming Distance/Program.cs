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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Solution So = new Solution();
			int x = 1,y=4;
			int result = So.HammingDistance(x,y);
			Console.WriteLine(result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}