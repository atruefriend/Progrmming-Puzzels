// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Requirement: merge two given arrays which contains sorted numbers
//output array should contains elements of both arrays in sorted order

int[] inputArray1 = new int[] { 0, 3, 4, 31 };
int[] inputArray2 = new int[] { 4, 6, 30 };
//output = [0,3,4,4,6,30,31]

//position for both arrays
//run should be run to the length of both arrays

//i will run a loop till the (sum)length of both arrays
//we will compare both items whatever is small we will push that in output

int length = inputArray1.Length + inputArray2.Length;
int array1Pos = 0;
int array2Pos = 0;
int[] output = new int[length];

for (int i = 0; i < length; i++)
{
    if (array1Pos == inputArray1.Length)
    {
        output[i] = inputArray2[array2Pos];
        array2Pos++;
    }
    else if (array2Pos == inputArray2.Length)
    {
        output[i] = inputArray1[array1Pos];
        array1Pos++;
    }
    else
    {
        if (inputArray1[array1Pos] < inputArray2[array2Pos])
        {
            output[i] = inputArray1[array1Pos];
            array1Pos++;
        }
        else
        {
            output[i] = inputArray2[array2Pos];
            array2Pos++;
        }
    }
}
Console.WriteLine("[{0}]", string.Join(", ", output));

