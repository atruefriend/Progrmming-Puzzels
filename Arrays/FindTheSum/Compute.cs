using System;
using System.Collections;

namespace FindTheSum
{
    public class Compute
    {
        //[1,2,6,9] - 8
        //[1,2,4,4] - 8
        public bool FindTheSumOfPairs(int[] possibleNumbers, int requiredSum)
        {
            Hashtable requiredValue = new Hashtable();

            for(int i =0; i < possibleNumbers.Length; i++)
            {
                //if value is greater the sum then we cannot find the output but if -ve numbers are allowed then we don't need this
                if(possibleNumbers[i] < requiredSum)
                {
                    int requiredNumber = requiredSum - possibleNumbers[i];

                    if(requiredNumber < requiredSum)
                    {
                        if(requiredValue.ContainsKey(requiredNumber))
                        {
                            return true;
                        }
                        else{
                            requiredValue.Add(requiredNumber, i);
                        }
                    }
                }
            }

            return false;
        }
    }
}