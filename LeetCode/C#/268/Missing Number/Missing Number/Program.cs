/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/5
 * 时间: 14:32
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Missing_Number
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int[] inputArray = new int[]{9,6,4,2,3,5,7,0,1};
			Solution So = new Solution();
			int result = So.MissingNumber(inputArray);
			Console.WriteLine(result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}