using System.Text.RegularExpressions;

/// <summary>
/// This class performs convertion of old phone key pad numbers to related alphabetical letters with input validation.
/// </summary>
public static class Keypad
{
    /// <summary>
    /// Mapping of digits to corresponding letters on an old phone keypad
    /// </summary>
    static Dictionary<char, string> keypad = new Dictionary<char, string>
    {
        {'2', "ABC"},
        {'3', "DEF"},
        {'4', "GHI"},
        {'5', "JKL"},
        {'6', "MNO"},
        {'7', "PQRS"},
        {'8', "TUV"},
        {'9', "WXYZ"}
    };

    /// <summary>
    /// This method will convert from numeric keys to alphabetic letters
    /// </summary>
    /// <param name="input">numeric keys sequence</param>
    /// <returns>Related alphabetic letters of input keys sequence</returns>
    public static string OldPhonePad(string input)
    {
        string message = "";

        try
        {
            for (int i = 0; i < input.Length; i++)
            {
                char key = input[i];
                int count = 1;

                while (i + 1 < input.Length && input[i + 1] == key)
                {
                    count++;
                    i++;
                }

                if (keypad.ContainsKey(key))
                {
                    string letters = keypad[key];
                    int index = (count - 1) % letters.Length;
                    message += letters[index];
                }
                else if (key.Equals('*'))
                {
                    message = message.Remove(message.Length - 1, 1);
                }
                else
                {
                    message += key;
                }
            }

            if (message.Length > 0 && Regex.IsMatch(message, "#$"))
            {
                message = message.Remove(message.Length - 1, 1).Replace(" ", "");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception : " + e);
        }

        return message;
    }


    /// <summary>
    /// Input validation 
    /// The valid input is the combination of numbers [2-9], zero or more space, zero or more '*' and '#' at the end.
    /// </summary>
    /// <param name="input">The input string to be validated.</param>
    /// <returns>Boolean value whether the input is valid or not</returns>
    public static bool IsValidInput(string input)
    {
        string pattern = @"^[2-9]+(?:\s*\**|\**\s*|[2-9]+)*#$";
        return Regex.IsMatch(input, pattern) ? true : false;
    }
}
