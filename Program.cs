using System;
using System.Text;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ===== Задание 1 =====
            string concatResult = ConcatenateStrings("Hello", " World");
            Console.WriteLine("Задание 1:");
            Console.WriteLine(concatResult);
            Console.WriteLine();

            // ===== Задание 2 =====
            string greet = GreetUser("Adam", 20);
            Console.WriteLine("Задание 2:");
            Console.WriteLine(greet);
            Console.WriteLine();

            // ===== Задание 3 =====
            string info = GetStringInfo("HeLLo WoRLd");
            Console.WriteLine("Задание 3:");
            Console.WriteLine(info);
            Console.WriteLine();

            // ===== Задание 4 =====
            string firstFive = GetFirstFiveCharacters("фыфывфывфывфыв");
            Console.WriteLine("Задание 4:");
            Console.WriteLine(firstFive);
            Console.WriteLine();

            // ===== Задание 5 =====
            string[] words = { "C#", "is", "a", "powerful", "language" };
            StringBuilder sentenceBuilder = BuildSentence(words);
            Console.WriteLine("Задание 5:");
            Console.WriteLine(sentenceBuilder.ToString());
            Console.WriteLine();

            // ===== Задание 6 =====
            string replaced = ReplaceWords("Hello world", "world", "universe");
            Console.WriteLine("Задание 6:");
            Console.WriteLine(replaced);
        }

        // ===== Задание 1 =====
        public static string ConcatenateStrings(string first, string second)
        {
            return first + second;
        }

        // ===== Задание 2 =====
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        // ===== Задание 3 =====
        public static string GetStringInfo(string input)
        {
            return $"Length: {input.Length}\n" +
                   $"Upper case: {input.ToUpper()}\n" +
                   $"Lower case: {input.ToLower()}";
        }

        // ===== Задание 4 =====
        public static string GetFirstFiveCharacters(string input)
        {
            return input.Substring(0, 5);
        }

        // ===== Задание 5 =====
        public static StringBuilder BuildSentence(string[] words)
        {
            StringBuilder sb = new StringBuilder();

            foreach (string word in words)
            {
                sb.Append(word).Append(" ");
            }

            return sb;
        }

        // ===== Задание 6 =====
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }
    }
}
