/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/4
 * 时间: 15:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Reshape_the_Matrix
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int[,] MatrixReshape(int[,] nums, int r, int c) 
		{
			if(r*c != nums.GetLength(0)*nums.GetLength(1))
				return nums;
			
			int[] Rearray = new int[r*c];
			int k=0;
			for(int i=0;i<nums.GetLength(0); i++)
			{
				for(int j=0;j<nums.GetLength(1); j++)
				{
					Rearray[k++] = nums[i,j];
				}
			}
			int[,] Matrix= new int[r,c];
			for(int i=0;i<r;i++)
			{
				for(int j=0;j<c;j++)
				{
					Matrix[i,j] = Rearray[i*c+j];
				}
			}
			return Matrix;
			
    	}
	}
}
