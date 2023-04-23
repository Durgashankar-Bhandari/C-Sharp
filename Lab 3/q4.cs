//Write a program in C# Sharp to display the characters and frequency of character from the string given by the user.
using System;
using System.Collections.Generic;

namespace CharacterFrequencyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            var charFrequency = GetCharacterFrequency(inputString);
            Console.WriteLine("Character\tFrequency");
            foreach (var pair in charFrequency)
            {
                Console.WriteLine(pair.Key + "\t\t" + pair.Value);
            }
            Console.ReadLine();
        }

        static Dictionary<char, int> GetCharacterFrequency(string inputString)
        {
            var charFrequency = new Dictionary<char, int>();
            foreach (char c in inputString)
            {
                if (charFrequency.ContainsKey(c))
                {
                    charFrequency[c]++;
                }
                else
                {
                    charFrequency[c] = 1;
                }
            }
            return charFrequency;
        }
    }
}
