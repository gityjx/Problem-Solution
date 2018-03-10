package com.leetcode;

public class Solution {
	
	public static int hammingWeight(int n) {
		
		String bitStr = Integer.toBinaryString(n);
		char[] bitChar = bitStr.toCharArray();
		int count = 0;
		for(int i =0; i<bitChar.length;i++)
		{
			if(bitChar[i] == '1')
				count ++;
		}
		
		return count;
        
    }

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int num =11;
		
		System.out.println(hammingWeight(num)); 
	}

}
