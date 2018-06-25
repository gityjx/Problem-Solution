/*
 * 由SharpDevelop创建。
 * 用户： yanjx
 * 日期: 2018/6/25
 * 时间: 15:24
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Binary_Tree_Level_Order_Traversal
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public IList<IList<int>> LevelOrder(TreeNode root)
    	{
//    		IList<IList<int>> result = new List<List<int>>();
    		IList<IList<int>> result = new List<IList<int>>();
    		Queue<TreeNode> tmpQueue = new Queue<TreeNode>();
    		tmpQueue.Enqueue(root);
    		while(tmpQueue.Count != 0)
    		{
    			List<int> tmpEle = new List<int>();
    			//
    			int size = tmpQueue.Count;
    			for (int i=0 ;i<size; i++)   //这里千万不要写 i<tmpQueue.Count 要把tmpQueue 的长度单独拿出来，因为循环完毕之后长度变了
    			{
    				TreeNode tmpNode = tmpQueue.Peek();
    				tmpEle.Add(tmpNode.val);
    				tmpQueue.Dequeue();
    				if(tmpNode.left != null) tmpQueue.Enqueue(tmpNode.left);
    				if (tmpNode.right != null) tmpQueue.Enqueue(tmpNode.right);
    			}
    			result.Add(tmpEle);
    		}
    		return result;
    			
        
    	}
	}
}
