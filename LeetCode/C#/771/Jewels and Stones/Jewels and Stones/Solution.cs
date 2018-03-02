/*
 * Created by SharpDevelop.
 * User: yadmin
 * Date: 2018/2/28
 * Time: 13:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Jewels_and_Stones
{
	/// <summary>
	/// Description of Solution.
	/// </summary>
	public class Solution
	{
		public int NumJewelsInStones(string J, string S) 
		{
			int Jlen = J.Length;
			int Slen = S.Length;
			int count = 0;
			for(int i=0; i<Jlen;i++)
			{
				for(int j=0;j<Slen;j++)
				{
					if(S[j] == J[i])
						++count;
				}
			}
			return count;
			
    	}
	}
}
