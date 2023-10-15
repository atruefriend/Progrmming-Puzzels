// See https://aka.ms/new-console-template for more information
using ReverseString;

Console.WriteLine("Hello, World!");

//requirement create a program which will reverse the given string
//for e.x. Input = "Hi!, My name is Nikhil Gupta."
//Output = ".atupG lihkiN si eman yM ,!iH"

//Another requirement is instead of reverse the string revese the words
//for e.x. Input = "Hi!, My name is Nikhil Gupta."
//Output = "Gupta. Nikhil is name My Hi!,"

Reverse reverse = new Reverse();
string input = "Hi!, My name is Nikhil Gupta.";

Console.WriteLine(reverse.ReverseTheGivenString(input, 1));
Console.WriteLine(reverse.ReverseTheGivenString(input, 2));