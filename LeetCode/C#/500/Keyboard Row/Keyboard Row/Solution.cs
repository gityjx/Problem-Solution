/*
 * 由SharpDevelop创建。
 * 用户： yanjx
 * 日期: 2018/3/20
 * 时间: 13:15
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Keyboard_Row
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public string[] FindWords(string[] words) 
		{
			
        	string arr1 = "qwertyuiop";
			string arr2 = "asdfghjkl";
			string arr3 = "zxcvbnm";
			HashSet<int> map1 = new HashSet<int>();
			Dictionary<char, int> map2 = new Dictionary<char, int>();
			Hashtable map3 =new Hashtable();
			
			for(int i=0;i<arr1.Length;i++)
			{
				map1.Add(i);
				map2.Add(arr1[i], 1);
				map3.Add(arr1[i], 1);
			}
			for(int i=0; i<arr2.Length;i++)
			{
				map1.Add(i);
				map2.Add(arr2[i], 2);
				map3.Add(arr2[i], 2);
			}
			for(int i=0; i<arr3.Length;i++)
			{
				map1.Add(i);
				map2.Add(arr3[i], 2);
				map3.Add(arr3[i], 2);
			}
			int flag = 0;
			List<string> lstStr = new List<string>();
			for(int i=0; i<words.Length;i++)
			{
				flag = 0;
				for(int j=0;j<words[i].Length;j++)
				{
					if(map2[char.ToLower(words[i][0])] != map2[char.ToLower(words[i][j])])
					{
						flag = 1;
						break;
					}

				}
				if(flag == 0)
					lstStr.Add(words[i]);
			}
			
			return lstStr.ToArray();
    	}
	}
}
