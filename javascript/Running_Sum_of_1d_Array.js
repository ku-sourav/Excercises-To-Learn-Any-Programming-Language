var runningSum = function(nums) {
    let csum = 0;
    let rsum = [];
    nums.forEach((num)=>{
        csum += num;
        rsum.push(csum);
    })
    return rsum;
};