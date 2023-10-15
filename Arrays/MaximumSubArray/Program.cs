// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

/*
Requirement: Given an integer array nums, find the subarray with the largest sum, and return its sum.

Example 1:

Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
Output: 6
Explanation: The subarray [4,-1,2,1] has the largest sum 6.
Example 2:

Input: nums = [1]
Output: 1
Explanation: The subarray [1] has the largest sum 1.
Example 3:

Input: nums = [5,4,-1,7,8]
Output: 23
Explanation: The subarray [5,4,-1,7,8] has the largest sum 23.
*/

//first i add up the 2 numbers and if the sum is greater then the current index value then keep both the numbers else drop the prior numbers


Tuple<int, int[]> GetMaxSubArray(int[] inputArray)
{
    int maxSum = inputArray[0];
    List<int> maxSumArray = new List<int>() { inputArray[0] };
    int sum = inputArray[0];
    List<int> subArray = new List<int>() { inputArray[0] };
    for (int i = 1; i < inputArray.Length; i++)
    {
        int value = inputArray[i];
        if (value + sum > value)
        {
            sum += value;
            subArray.Add(value);
        }
        else
        {
            sum = value;
            subArray = new List<int>() { value };
        }

        if (sum > maxSum)
        {
            maxSum = sum;
            maxSumArray = subArray.ToList();
        }
    }
    return new Tuple<int, int[]>(item1: maxSum, item2: maxSumArray.ToArray() );
}

var maxSubArray = GetMaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
//var maxSubArray = GetMaxSubArray(new int[] { 1 });
//var maxSubArray = GetMaxSubArray(new int[] { 5,4,-1,7,8 });

Console.WriteLine(maxSubArray.Item1);
Console.WriteLine("[{0}]", string.Join(" ,", maxSubArray.Item2));