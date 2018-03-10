/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 14:56
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Toeplitz_Matrix
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public bool IsToeplitzMatrix(int[,] matrix) 
		{
			int r = matrix.GetLength(0);
			int c = matrix.GetLength(1);
			for(int i=1;i<r;i++)
			{
				for(int j=1; j<c;j++)
				{
					if(matrix[i,j] != matrix[i-1, j-1])
						return false;
				}
			}
			return true;
			
			
    	}
	}
}
