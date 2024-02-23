public class Solution {
    public IList<IList<int>> PermuteUnique(int[] numbers) {
        List<IList<int>> ans = new List<IList<int>>();
        List<int> nums = new List<int>();
        List<int> curr = new List<int>();
        HashSet<string> unique = new HashSet<string>();
        
        for(int i = 0; i < numbers.Length; i++){
            nums.Add(numbers[i]);
        }
        
        void backtracking(){
            for(int i = 0; i < nums.Count; i++){
                curr.Add(nums[i]);
                nums.RemoveAt(i);
                if(nums.Count <= 0){
                    string permutation = string.Join(",", curr);
                    if(!unique.Contains(permutation)){
                        ans.Add(new List<int>(curr));
                        unique.Add(permutation);
                    }
                }
                else{
                    backtracking();
                }
                nums.Insert(i, curr[curr.Count - 1]);
                curr.RemoveAt(curr.Count - 1);
            }
        }
        
        backtracking();
        return ans;
    }
}
