/*
 * Created by SharpDevelop.
 * User: yadmin
 * Date: 2018/2/28
 * Time: 13:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Jewels_and_Stones
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			Solution So = new Solution();
			string J = "aA";
			string S = "aAAbbbb";
			int count = So.NumJewelsInStones(J,S);
			Console.WriteLine(count);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}