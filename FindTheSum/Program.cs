// See https://aka.ms/new-console-template for more information
using FindTheSum;

//Console.WriteLine("Hello, World!");

//inputs
int[] numbers = new int[] {1, 2, 4, 4};
int sum = 8;
Compute c = new Compute();
bool result = c.FindTheSumOfPairs(numbers, sum);

Console.WriteLine(result);