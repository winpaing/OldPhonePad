using System;
using System.Collections.Generic;
using System.Linq;

class OldKeypad
{
    // Define the key mappings (A-Z) with example mappings.
    private static readonly Dictionary<char, string> KeyMappings = new Dictionary<char, string>
    {
        { 'A', "2" }, { 'B', "22" }, { 'C', "222" },
        { 'D', "3" }, { 'E', "33" }, { 'F', "333" },
        { 'G', "4" }, { 'H', "44" }, { 'I', "444" },
        { 'J', "5" }, { 'K', "55" }, { 'L', "555" },
        { 'M', "6" }, { 'N', "66" }, { 'O', "666" },
        { 'P', "7" }, { 'Q', "77" }, { 'R', "777" }, { 'S', "7777" },
        { 'T', "8" }, { 'U', "88" }, { 'V', "888" },
        { 'W', "9" }, { 'X', "99" }, { 'Y', "999" }, { 'Z', "9999" },
        { ' ', " " } // Space character
    };

    static void Main(string[] args)
    {
        bool continueRunning = true;

        while (continueRunning)
        {
            Console.Write("Enter Number: ");
            string input = Console.ReadLine().ToUpper();

            // Validate the input format
            if (!IsValidInput(input))
            {
                Console.WriteLine("Invalid input. Please enter only English Alphabet.");
                continue;
            }

            string result = DecodeInput(input);
            Console.WriteLine("Results is : " + result);

            Console.Write("Continue Y/N: ");
            string response = Console.ReadLine().Trim().ToUpper();
            continueRunning = response == "Y";
        }
    }

    private static bool IsValidInput(string input)
    {
        return input.All(c => char.IsDigit(c) || c == '*' || c == '#' || c == ' ');
    }

    private static string DecodeInput(string input)
    {
        var result = new List<char>();
        var tempInput = input;

        while (tempInput.Length > 0)
        {
            if (tempInput[0] == '*')
            {
                if (result.Count > 0)
                {
                    result.RemoveAt(result.Count - 1);
                }
                tempInput = tempInput.Substring(1);
            }
            else if (tempInput[0] == '#')
            {
                tempInput = tempInput.Substring(1); // Skip the '#' character
            }
            else
            {
                char key = tempInput[0];
                int count = 0;

                while (tempInput.Length > 0 && tempInput[0] == key)
                {
                    tempInput = tempInput.Substring(1);
                    count++;
                }

                // Adjust the count to get the correct character
                count--;

                if (key == ' ') // Handle space directly if it appears
                {
                    result.Add(' ');
                }
                else
                {
                    char decodedChar = GetCharacter(key, count);
                    if (decodedChar != '\0')
                    {
                        result.Add(decodedChar);
                    }
                }
            }
        }

        return new string(result.ToArray());
    }

    private static char GetCharacter(char key, int pressCount)
    {
        foreach (var pair in KeyMappings)
        {
            if (pair.Value.Length == pressCount + 1 && pair.Value[0] == key)
            {
                return pair.Key;
            }
        }
        return '\0'; // Character not found
    }
}
