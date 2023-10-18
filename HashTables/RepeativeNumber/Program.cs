// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");

/*
Requirement:
First the first repeating number

for e.x. 
input = [2,5,1,2,3,5,1,2,4];
ouput = 2;

input = [2,1,1,2,3,5,1,2,4]
output = 1

input = [2,3,4,5]
output = "No repeating number found"
*/

string GetFirstRepeatingNumber(int[] array)
{
    Hashtable hash = new Hashtable();
    for (int i = 0; i < array.Length; i++)
    {
        if (hash.ContainsKey(array[i]))
        {
            return array[i].ToString();
        }
        else
        {
            hash.Add(array[i], i);
        }
    }
    return "No repeating number found!";
}

Console.WriteLine(GetFirstRepeatingNumber(new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 }));
Console.WriteLine(GetFirstRepeatingNumber(new int[] { 2,1,1,2,3,5,1,2,4 }));
Console.WriteLine(GetFirstRepeatingNumber(new int[] { 2,3,4,5 }));
