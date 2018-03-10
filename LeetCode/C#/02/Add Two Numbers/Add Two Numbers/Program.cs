/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/10
 * 时间: 12:53
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Add_Two_Numbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode  node1 = new ListNode(2);
			node1.next = new ListNode(4);
			node1.next.next = new ListNode(3);
			
			ListNode node2 = new ListNode(5);
			node2.next = new ListNode(6);
			node2.next.next = new ListNode(4);
			
			Solution So = new Solution();
			ListNode result = So.AddTwoNumbers(node1, node2);
			Console.WriteLine(result.next.val);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}