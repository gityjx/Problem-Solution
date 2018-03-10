package Subsets_result;

import java.util.ArrayList;
import java.util.List;

public class Solution {  
    public List<List<Integer>> subsets(int[] nums) {  
        List<List<Integer>> res = new ArrayList<List<Integer>>();  
        List<Integer> temp = new ArrayList<Integer>();  
        dfs(res, temp, nums, 0);  
        return res;  
    }  
    private void dfs(List<List<Integer>> res, List<Integer> temp, int[] nums, int j) {  
        res.add(new ArrayList<Integer>(temp));  
        for(int i = j; i < nums.length; i++) {  
            temp.add(nums[i]);  //¢Ù ¼ÓÈë nums[i]  
            dfs(res, temp, nums, i + 1);  //¢Ú µİ¹é  
            temp.remove(temp.size() - 1);  //¢Û ÒÆ³ı nums[i]  
        }  
    }  
    public void Main(String[] args) {
    	
    	int[] nums = new int[] {1,2,3};
    	Solution So = new Solution();
    	List<List<Integer>> result= So.subsets(nums);
    	System.out.println("Complete!");
    }
}  