/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/7
 * 时间: 13:16
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Reverse_Linked_List
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	
	public class Solution
	{
		public ListNode ReverseList(ListNode head) 
		{
        if(head.next == null || head == null)
        {
            return head;
        }
            
        ListNode pre = head;
        ListNode p = head.next;
        pre.next = null;
        ListNode nxt;
        while(p != null)
        {
            nxt = p.next;
            p.next = pre;
            pre = p;
            p = nxt;
        }
        
        return pre;
        
		}
        
    }
}
