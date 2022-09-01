using System;
using System.Collections.Generic;

namespace OcurrenceEachCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string statement = "hello world";

            Dictionary<char, int> output = CountCharacters(statement);

            foreach (var item in output)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
            }            
        }

        public static Dictionary<char, int> CountCharacters(string input)
        {            
            Dictionary<char, int> keyValues = new Dictionary<char, int>();            
            
            for(int i=0; i < input.Length; i++)
            {
                char character = input[i];                
                if (character != ' ')
                {                    
                    if (!keyValues.ContainsKey(character))
                    {
                        keyValues.Add(character, 1);
                    }
                    else
                    {
                        keyValues[character] += 1; // increment 1 to that "character" key
                    }
                }
            }
            
            return keyValues;
        }
    }
}
