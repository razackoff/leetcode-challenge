public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
       // int[] res = new int[nums1.Length+nums2.Length]
       //int size= 0;
       List<int> output = new List<int>();
       for(int i=0 ; i< nums1.Length;i++)
        {
            for(int j =0 ; j<nums2.Length;j++)
            {
                if(nums1[i]==nums2[j])
                {
                    if(!output.Contains(nums1[i]))
                    {
                        output.Add(nums1[i]);
                    }
                }
            }
        }
        int[] res = output.ToArray();
        return res;
    }
}