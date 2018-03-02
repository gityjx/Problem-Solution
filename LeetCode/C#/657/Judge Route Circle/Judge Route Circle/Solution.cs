/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/1
 * 时间: 15:50
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;

namespace Judge_Route_Circle
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public bool JudgeCircle(string moves) 
    	{
    		int Lcount = 0, Rcount = 0, Ucount = 0, Dcount = 0;
    		moves = moves.ToUpper();
    		for(int i=0;i<moves.Length;i++)
    		{
    			switch(moves[i])
    			{
    				case 'L':
    					++Lcount;
    					break;
    				case 'R':
    					++Rcount;
    					break;
    				case 'U':
    					++Ucount;
    					break;
    				case 'D':
    					++Dcount;
    					break;
    				default:
    					break;
    			}
    		}
    		if(Lcount == Rcount && Ucount == Dcount)
    		{
    			return true;
    		}
    		return false;
    	}
	}
}
