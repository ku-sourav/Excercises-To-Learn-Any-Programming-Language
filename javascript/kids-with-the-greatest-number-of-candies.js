var kidsWithCandies = function(candies, extraCandies) {
    
    /* Different ways of finding the max */
    /*let maxcandy = candies.reduce((a,b)=>{
        return Math.max(a,b);
    });
    
    let maxcandy = Math.max.apply(null, candies); */
    
    let maxcandy = Math.max(...candies);
    
    let boolean = new Array(candies.length);
    for (let i = 0; i < candies.length; i++) {
        boolean[i] = candies[i]+extraCandies >= maxcandy;
    }
   
    return boolean;
};