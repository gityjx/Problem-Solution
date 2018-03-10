/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 14:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Toeplitz_Matrix
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int[ , ] input = new int[3,4]{{1,2,3,4},{5,1,2,3},{9,5,1,2}};
			Solution So = new Solution();
			bool result = So.IsToeplitzMatrix(input);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}