using System.Text.RegularExpressions;

public static class Keypad
{
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
                message = message.Remove(message.Length - 1, 1);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception : " + e);
        }

        return message;
    }

  

    public static bool IsValidInput(string input)
    {
        string pattern = @"^[2-9]+(?:\s*\**|\**\s*|[2-9]+)*#$";
        return Regex.IsMatch(input, pattern) ? true : false;
    }
}
