/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/1
 * 时间: 20:36
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Array_Partition_I
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			int[] input = new int[]{1,4,3,2};
			Solution So = new Solution();
			int result = So.ArrayPairSum(input);
			Console.WriteLine(result);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}