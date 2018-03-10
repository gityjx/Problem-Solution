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
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			uint num = 10532;
			Solution So = new Solution();
			uint result = So.reverseBits(num);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}