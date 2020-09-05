public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
       
        /* using System.Linq; */
        int maxcandy = candies.Max();

        /* without linq */
        maxcandy = Int32.MinValue;
        foreach (var num in arr)
        {
            if (num > maxval)
                maxval = num;
        }
        List<bool> res = new List<bool>();
        foreach(var candy in candies){
            res.Add(candy+extraCandies>=maxcandy);
        }
        return res;
    }
}