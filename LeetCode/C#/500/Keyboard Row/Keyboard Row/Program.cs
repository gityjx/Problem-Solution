/*
 * 由SharpDevelop创建。
 * 用户： yanjx
 * 日期: 2018/3/20
 * 时间: 12:55
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Collections;

namespace Keyboard_Row
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			string[] words = new string[]{"Hello", "Alaska", "Dad", "Peace"};
			Solution So = new Solution();
			string[] result = So.FindWords(words);
			for(int i=0;i<result.Length;i++)
			{
				Console.WriteLine(result[i]);
			}
			
			Dictionary<char,int> table1 = new Dictionary<char, int>();
			table1.Add('a',1);
			table1.Add('b',1);
			if(table1['a'] == table1['b'])
			{
				Console.WriteLine("Yes！");
				Console.WriteLine(table1['a']+"&"+table1['b']);
			}
				
			else
			{
				Console.WriteLine("No!");
				Console.WriteLine(table1['a']+"&"+table1['b']);
			}
			object a = 1;
			object b = 1;
			Console.WriteLine(a.GetType());
			if(a==b)
			{
				Console.WriteLine("a==b");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}