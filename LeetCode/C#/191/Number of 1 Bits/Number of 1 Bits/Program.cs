/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/6
 * 时间: 15:26
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Number_of_1_Bits
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			uint inputNum = 11;
			Solution So = new Solution();
			int result = So.HammingWeight(inputNum);
			Console.WriteLine(result);
			Console.WriteLine(11&1);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}