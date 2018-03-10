/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/7
 * 时间: 15:41
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Merge_Two_Sorted_Lists
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode node1 = new ListNode(1);
			ListNode node2 = new ListNode(2);
			ListNode node3 = new ListNode(4);
			ListNode node4 = new ListNode(1);
			ListNode node5 = new ListNode(3);
			ListNode node6 = new ListNode(4);
			node1.next = node2;
			node2.next = node3;
			node4.next = node5;
			node5.next = node6;
			Solution So =new Solution();
			ListNode resultNode = So.MergeTwoLists(node1, node4);
			Console.WriteLine(resultNode.val);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}