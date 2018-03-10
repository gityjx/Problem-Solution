/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/7
 * 时间: 13:14
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Reverse_Linked_List
{

	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode node1 = new ListNode(1);
			ListNode node2 = new ListNode(2);
			ListNode node3 = new ListNode(3);
			node1.next = node2;
			node2.next = node3;
			Console.WriteLine(node1.next.val);
			Solution So = new Solution();
			ListNode resultHead = So.ReverseList(node1);
			Console.WriteLine(resultHead.val);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}