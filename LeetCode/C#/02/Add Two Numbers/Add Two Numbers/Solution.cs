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
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public ListNode AddTwoNumbers(ListNode l1, ListNode l2) 
    {
        ListNode result = new ListNode(0);
        ListNode numNode = result;
        int shang = 0;
        int yu = 0;
        int sum = 0;
        while(l1 !=null && l2 != null)
        {
            sum = shang + l1.val + l2.val;
            if(sum > 9)
            {
                yu = sum%10;
                shang = sum/10;
                numNode.next =  new ListNode(yu);
            }
            else
            {
                numNode.next = new ListNode(sum);
                shang = 0;
            }
            
            numNode = numNode.next;
            l1 = l1.next;
            l2 = l2.next;
        }

        if(l1 != null)
            l2 =l1;
        
        while(l2 != null)
        {
            sum = l2.val+shang;
            if(sum>9)
            {
                yu = sum%10;
                shang = sum/10;
                numNode.next =  new ListNode(yu);
            }
            else
            {
                numNode.next = new ListNode(sum);
                shang =0;
            }

            l2 = l2.next;
            numNode = numNode.next;
        }
        if(shang !=0)
            numNode.next =  new ListNode(shang);
        return result.next;
    }
	}
}
