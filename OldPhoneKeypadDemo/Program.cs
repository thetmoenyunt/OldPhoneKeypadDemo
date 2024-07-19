using System.Text.RegularExpressions;

string output = "";
string input = "";

Console.WriteLine("=======================================================================");
Console.WriteLine("The valid input keys are Numeric keys [0-9], zero or more space, ");
Console.WriteLine("zero or more '*' and '#' must be at the end.");
Console.WriteLine();
Console.WriteLine("Example Inputs: '33#', '227*#', '4433555 555666#', '8 88777444666*664#'");
Console.WriteLine();
Console.WriteLine("To quit the application, please type \"exit\" ");
Console.WriteLine("=======================================================================");

do
{
    input = GetInput();
    output = Keypad.OldPhonePad(input);
    Console.WriteLine($"Output text message : {output}");
    Console.WriteLine();
}
while (true);


string GetInput()
{
    Console.Write("Enter the key sequence : ");
            
    string input = new string(Console.ReadLine());
    string pattern = @"\d[\s\*]*#";
    string exitPattern = "exit";

    if(input.ToLower().Equals(exitPattern))
    {
        Console.WriteLine("Application will be exit.");
        Environment.Exit(0);
    }
    
    if (!Regex.IsMatch(input, pattern))
    {
        Console.WriteLine("Invalid input!");
        input = GetInput();
    }

    return input;
}
