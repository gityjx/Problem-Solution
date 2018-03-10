/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/8
 * 时间: 21:51
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Intersection_of_Two_Linked_Lists
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode node1_1 = new ListNode(1);
			ListNode node1_2 = new ListNode(2);
			ListNode node1_3 = new ListNode(3);
			ListNode node2_1 = new ListNode(3);
			ListNode node2_2 = new ListNode(2);
			ListNode node2_3 = new ListNode(3);

			node1_1.next = node1_2;
			node1_2.next = node1_3;
			node2_1.next = node2_2;
			node2_2.next = node2_3;
			Solution So = new Solution();
			ListNode result = So.GetIntersectionNode(node1_1, node2_1);
			Console.WriteLine(result.val);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}