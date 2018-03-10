/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/9
 * 时间: 16:57
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Remove_Nth_Node_From_End_of_List
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public ListNode deleteNode(ListNode head, int num)
		{
			if(head == null || num <0)
				return head;
			ListNode p =head;
			ListNode q = new ListNode(0);
			int i=1;
			while(p.next != null && i <num)
			{
				i++;
				q = p;
				p = p.next;
			}
			if(i == num)
			{
				q.next = p.next;
			}
			
			return head;
		}
	}
}
