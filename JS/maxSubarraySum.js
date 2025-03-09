//sliding window
function maxSubarraySum(arr, num) {
  if(num > arr.length){
    return null;
  }

  let maxSum = 0;
  let tempSum = 0;

  for(let i =0; i < num; i++){
    maxSum += arr[i];
  }
  tempSum = maxSum;
  for(let i = num; i < arr.length; i++){
    tempSum = tempSum - arr[i - num] + arr[i];
    maxSum = Math.max(maxSum, tempSum);
  }
  return maxSum;
  
}
// Time complexity - O(N)
console.log(maxSubarraySum([1,2,5,2,8,1,5], 2));// 10:
console.log(maxSubarraySum([1,2,5,2,8,1,5], 4));// 17
console.log(maxSubarraySum([4,2,1,6], 1)); //6
console.log(maxSubarraySum([4,2,1,6,2], 4));// 13
console.log(maxSubarraySum([], 4));// null
