using System;

namespace RunningSum
{
    /* using List<int> */
    public class Solution1
    {
        public int[] RunningSum(int[] nums)
        {
            List<int> rsum = new List<int>();
            int csum = 0;
            foreach (var num in nums)
            {
                csum += num;
                rsum.Add(csum);
            }
            /*convert list to array*/
            return rsum.ToArray();
        }
    }

    /* using simple array */
    public class Solution2 {
    public int[] RunningSum(int[] nums) {
        int[] res = new int[nums.Length];
        int csum = 0;
        for (int i = 0; i < nums.Length; i++){
            csum += nums[i];
            res[i] = csum;
        }
        return res;
    }
}
}
