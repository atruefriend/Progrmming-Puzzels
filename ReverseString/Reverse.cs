namespace ReverseString
{
    public class Reverse
    {
        //we have to perform two types of reverse
        //so we can say there will be inputs 
        //first is string
        //a type which depicts which type of reverse we have to perform
        public enum ReverseType : int
        {
            Complete = 1,
            Word = 2
        }

        public string ReverseTheGivenString(string input, int reverseType)
        {
            //in the both the case we have to loop on all the characters
            //case 1: we have to reverse all the characters as it as
            //case 2: we have to reverse when we found space

            //first lets convert our string into an array
            //in c# we have direct toArray available but here we will do it by our own

            switch ((ReverseType)reverseType)
            {
                case ReverseType.Complete:
                    return CompleteReverse(input);
                case ReverseType.Word:
                    return WordReverse(input);
            }

            return "Some Error Occured!";

        }

        string CompleteReverse(string input)
        {
            string output = string.Empty;

            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        string WordReverse(string input)
        {
            string[] inputs = Split(input, ' ');
            string output = string.Empty;

            for (int i = inputs.Length - 1; i >= 0; i--)
            {
                if(inputs[i] != null)
                {
                    output += inputs[i] + " ";
                }
            }
            return output;
        }

        string[] Split(string input, char splitWith)
        {
            int pos = 0;
            string[] wordArray = new string[input.Length];
            string word = string.Empty;

            for (int i = 0; i <= input.Length; i++)
            {
                if ((i == input.Length || input[i] == splitWith) && word.Length > 0)
                {
                    wordArray[pos] = word;
                    pos++;
                    word = string.Empty;
                }
                else
                {
                    word += input[i];
                }
            }

            // string[] output = new string[pos];
            // for (int i = 0; i < pos; i++)
            // {
            //     output[i] = wordArray[i];
            // }
            // return output;
            return wordArray;
        }
    }
}