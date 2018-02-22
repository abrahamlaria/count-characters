using System;

namespace CountCharacters
{
    class Program
    {
        //Count characters at same position as in English alphabet.        
        public static int FindCount(string str)
        {
            var result = 0;

            /*Check that index of characters of the string are the same as of English alphabet by using
             ASCII values and the fact that all lower case alphabetic characters come together in the same order in ASCII table. 
             Same is tru for uppercase*/

            for (var i = 0; i <= 26; i++)
            {
                //if (i == (str[i] - 'a') || (i == str[i] - 'A'))
                if ((i ^ str[i] - 'a') == 0 || (i ^ str[i] - 'A') == 0)
                {
                    result++;
                    //Print to the console the characters and their position in the string.
                    Console.Write("Character: " + str[i] + " at position: " + i + "\n");
                }                                      
            }
            //Return the total number of found characters
            return result;
        }
        static void Main(string[] args)
        {
            const string str = "ABCed";
            Console.Write("Total number of matching characters: " + FindCount(str));
            Console.ReadLine();
        }
    }
}
