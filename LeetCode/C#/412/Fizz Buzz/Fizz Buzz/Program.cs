/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/6
 * 时间: 16:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Fizz_Buzz
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int num =1;
			Solution So = new Solution();
			IList<string> result  = So.FizzBuzz(num);
			Console.WriteLine(result[0]);
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}