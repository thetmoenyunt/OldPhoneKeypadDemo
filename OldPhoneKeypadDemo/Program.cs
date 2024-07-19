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
    if(!Keypad.IsValidInput(input))
    {
        Console.WriteLine("Invalid input !!!");
        GetInput();
    }

    return input;
}


