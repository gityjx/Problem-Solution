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
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public bool IsPalindrome(ListNode head) 
    {
        if(head == null || head.next == null)
            return true;
        ListNode fastNode = head;
        ListNode slowNode = head;
        while(fastNode != null && fastNode.next != null)
        {
            fastNode = fastNode.next.next;
            slowNode = slowNode.next;
        }
        if(fastNode == null) // 偶数
        {
            slowNode = ReverseList(slowNode);
        }else
        {
            slowNode = ReverseList(slowNode.next);
        }
        while(slowNode != null)
        {
            if(slowNode.val != head.val)
                return false;
            slowNode = slowNode.next;
            head = head.next;
        }
        return true;
        
        
        
        
        
        // if(fastNode == null) // 偶数
        // {
        //     while(head == slowNode.next&& head.next != null)
        //     {
        //         head = head.next;
        //         slowNode = slowNode.next;
        //     }
        // }else
        // {
        //     while(head == slowNode.next.next && head.next != null)
        //     {
        //         head = head.next;
        //         slowNode = slowNode.next;
        //     }
        // }
        // if (slowNode.next == null)
        //     return true;
        // return false;
    }
    public ListNode ReverseList(ListNode head)
    {
        
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
