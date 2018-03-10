/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/9
 * 时间: 16:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Remove_Nth_Node_From_End_of_List
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ListNode head;
			ListNode node1 = new ListNode(1);
			ListNode node2 = new ListNode(2);
			node1.next = node2;
			head = node1.next;
			Console.WriteLine(head.val);
			
			int aaa = 807;
			string straaa = aaa.ToString();
			int result = int.Parse(straaa[2].ToString());
			Console.WriteLine(result);
//			Console.WriteLine(aaa.ToString());
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}