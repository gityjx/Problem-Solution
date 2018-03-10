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
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		
		public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
		{

			
			
			
			if(l1 == null) return l2;
			if(l2 == null) return l1;
			ListNode result = new ListNode(0);
			ListNode Hc = result;
			while(l1 != null && l2 != null)
			{
				if(l1.val < l2.val)
				{
					Hc.next = l1;
					l1 = l1.next;
				}
				else
				{
					Hc.next = l2;
					l2 = l2.next;
				}
			Hc = Hc.next;
			}
			
			if(l1 != null)
			{
				l2 = l1;
			}


			while(l2 != null)
			{
				Hc.next = l2;
				Hc = Hc.next;
				l2 = l2.next;
			}
			
			
			return result.next;
			
			
			

			
			
			
			
			
//			if(l1 == null) return l2;
//			if(l2 == null) return l1;
//			
//			if(l1.val > l2.val)
//			{
//				ListNode tmp = l2;
//				tmp.next = MergeTwoLists(l1, l2.next);
//				return tmp;
//			}
//			else
//			{
//				ListNode tmp = l1;
//				tmp.next = MergeTwoLists(l1.next, l2);
//				return tmp;
//			}
//				
			
			
			
			
			
    	}
	}
}
