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
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    	{
        
       int i=0, j=0;
       ListNode headA_tmp = headA;
       ListNode headB_tmp = headB;
        
        while(headA_tmp != null)
        {
            i++;
            headA_tmp = headA_tmp.next;
        }
        while(headB_tmp != null)
        {
            j++;
            headB_tmp = headB_tmp.next;
        }
        int flag = 0;
        int listLen = 0;
        if(i > j)
        {
            listLen = i-j;
            flag = 1;
        }else
        {
            listLen = j-i;
            flag = 2;
        }
        
        //changde xianzou
        if(flag ==1)
        {
            while(listLen >0)
            {
                headA = headA.next;
                listLen--;
            }
        }else
        {
            while(listLen >0)
            {
                headB = headB.next;
                listLen--;
            }
        }
        //
        while(headA != null && headB != null)
        {
            if(headA.val == headB.val)
                return headA;
            headA = headA.next;
            headB = headB.next;
        }
        return null;
        
            
    	}
	}
}
