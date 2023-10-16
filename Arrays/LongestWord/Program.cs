// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
Console.WriteLine("Hello, World!");
/*
Requirement: Have the function LongestWord(sen) take the sen parameter being passed and return 
the longest word in the string. If there are two or more words that are the same length, 
return the first word from the string with that length. Ignore punctuation and assume sen will not be empty.
 Words may also contain numbers, for example "Hello world123 567"

    Input: "fun&!! time"
    Output: time

    Input: "I love dogs"
    Output: love
*/

string LongestWord(string sen)
{
    string[] words = sen.Split(' ');
    int maxLength = 0;
    string longestWord = string.Empty;
    for (int i = 0; i < words.Length; i++)
    {
        string word = words[i];
        word = Regex.Replace(word, "[^a-z]+", "");
        if (word.Length > maxLength)
        {
            maxLength = word.Length;
            longestWord = word;
        }
    }
    return longestWord;

}

Console.WriteLine(LongestWord("fun&!! time"));