/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/8
 * 时间: 21:15
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Palindrome_Linked_List
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode node1 = new ListNode(1);
			ListNode node2 = new ListNode(2);
			node1.next = node2;
			Solution So = new Solution();
			bool result = So.IsPalindrome(node1);
			Console.WriteLine(result);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}