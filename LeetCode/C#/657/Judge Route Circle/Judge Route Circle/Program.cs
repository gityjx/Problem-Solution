/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/1
 * 时间: 15:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Judge_Route_Circle
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Solution So = new Solution();
			string input = "ud";
			bool output = So.JudgeCircle(input);
			Console.WriteLine(output);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}