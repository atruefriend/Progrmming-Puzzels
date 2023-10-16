// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

/*
Requirement: Given an integer array nums, move all 0's to the end of it while maintaining 
the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]

Example 2:

Input: nums = [0]
Output: [0]
*/

int[] MoveZeros(int[] inputArray)
{
    int length = inputArray.Length;
    int minZeroIndex = -1;
    for(int i = 0; i< length; i++)
    {
        int inputNumber = inputArray[i];
        if(inputNumber != 0)
        {
            if(minZeroIndex > -1)
            {
                inputArray[minZeroIndex] = inputNumber;
                inputArray[i] = 0;
                minZeroIndex++;
            }
        }
        else{
            if(minZeroIndex == -1)
            {
                minZeroIndex = i;
            }
        }
    }

    return inputArray;
}

int[] result = MoveZeros(new int[] {0,1,0,3,12});

Console.WriteLine("[{0}]", string.Join(" ,", result));