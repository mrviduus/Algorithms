function countUniqueValues(arr){
  if(arr.length === 0){
    return 0;
  }
  let count = 0;
  for(let i = 0; i < arr.length; i++){
      if(arr[count] !== arr[i]){
      count ++;
      arr[count] = arr[i];
    }
  }
  return count + 1;
}

console.log(countUniqueValues([1,1,1,1,2]));// 2:
console.log(countUniqueValues([1,2,3,4,4,7,7,12,12,13]));// 7
console.log(countUniqueValues([]));// 0
console.log(countUniqueValues([-2,-1,-1,0,1]));// 2
