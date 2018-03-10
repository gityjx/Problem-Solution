/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 15:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Reshape_the_Matrix
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int[,] nums= new int[2,2]{{1,2},{3,4}};
			Solution So = new Solution();
			int[,] result= So.MatrixReshape(nums,1,4);
			Console.WriteLine(result[0,3]);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}