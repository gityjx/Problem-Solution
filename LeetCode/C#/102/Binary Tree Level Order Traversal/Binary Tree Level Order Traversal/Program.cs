/*
 * 由SharpDevelop创建。
 * 用户： yanjx
 * 日期: 2018/6/25
 * 时间: 15:18
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Binary_Tree_Level_Order_Traversal
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			TreeNode root  = new TreeNode(3);
			root.left = new TreeNode(9);
			root.right =new TreeNode(20);
			root.right.left = new TreeNode(15);
			root.right.right = new TreeNode(7);
			
			Solution SO = new Solution();
			IList<IList<int>> result =  SO.LevelOrder(root);
			Console.WriteLine(result[0].Count);
			Console.WriteLine(result[1].Count);
			Console.WriteLine(result[2].Count);
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}