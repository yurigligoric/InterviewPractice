using System.Runtime.InteropServices;

namespace InterviewPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string reverseWord = Reverse("Ern");
            Console.WriteLine(reverseWord);

            //Reverse("hello");
            Console.WriteLine(Palindrome("hello", "yolleh"));
            


        }
        
        public static string Reverse(string word)
        {
            int letterCount = word.Length;
            char[] reverseLetter = new char[letterCount];
            int letterCountFor = letterCount -1;
            for (int i = 0; i < letterCount; i++)
            {
                char reverseWord = word[letterCountFor];
                letterCountFor--;
                reverseLetter[i] = reverseWord;
                
            }

            //Console.WriteLine(reverseLetter);

            return new string(reverseLetter);
        }

        public static bool Palindrome(string word, string word2)
        {
            string ReverseWord = Reverse(word);

            if (ReverseWord == word2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}