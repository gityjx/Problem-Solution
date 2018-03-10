/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/2
 * 时间: 18:21
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace House_Robber
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int[] input =new int[]{3,8,4};
			Solution So = new Solution();
			int result = So.Rob(input);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}