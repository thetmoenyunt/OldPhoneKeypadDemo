internal class Program
{
    private static void Main(string[] args)
    {
        string output = "";
        string input = "";

        Console.WriteLine("=======================================================================");
        Console.WriteLine("The valid input is the combination of numbers [2-9], zero or more space, ");
        Console.WriteLine("zero or more '*' and '#' at the end.");
        Console.WriteLine();
        Console.WriteLine("Example Inputs: '33#', '227*#', '4433555 555666#', '8 88777444666*664#'");
        Console.WriteLine();
        Console.WriteLine("To quit the application, please enter (\"Ctrl + C\") ");
        Console.WriteLine("=======================================================================");

        do
        {
            Console.Write("Enter the key sequence : ");
            input = new string(Console.ReadLine());

            if (Keypad.IsValidInput(input))
            {
                output = Keypad.OldPhonePad(input);
                Console.WriteLine($"Output text message : {output}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input !!!");
            }

        }
        while (true);
    }
}