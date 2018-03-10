/*
 * 由SharpDevelop创建。
 * 用户： yadmin
 * 日期: 2018/3/6
 * 时间: 16:46
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;

namespace Fizz_Buzz
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
    	public IList<string> FizzBuzz(int n) 
    	{
    		IList<string> result = new List<string>();
    		for(int i=1;i<=n;i++)
    		{
    			if (i%3 ==0 && i%5 != 0)
    				result.Add("Fizz");
    			else if(i%3 !=0 && i%5 == 0)
    				result.Add("Buzz");
    			else if(i%3 ==0 && i%5 == 0)
    				result.Add("FizzBuzz");
    			else
    				result.Add(i.ToString());
    		}
    		return result;
    		
    	}
	}
}
