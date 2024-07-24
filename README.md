
# Old Phone Keypad


This demo project involves sending messages using an old phone keypad that features alphabetical letters, a backspace key, and a send button. Each button is identified by a number, and pressing a button multiple times cycles through the letters it represents. For instance, pressing the '2' button once yields 'A', pressing it twice yields 'B', and so on. To type two characters from the same button consecutively, you must pause for a second between presses. For example, "222 2 22" translates to "CAB".

It was implemented as a Console Application with C#. It can convert from a key sequences to alphabetical letters.
## Features

- Input validation
- Convert from numeric keys to represented alphabetical letters
- Unit Testing

Input will be valided as per below RegEx Pattern.

^[2-9]+(?:\s*\**|\**\s*|[2-9]+)*#$

- ^[2-9]+   starting with one or more number between 2-9
- (?:)*     matches everything enclosed
- \s*       zero or more space
- \**       zero or more '*' character
- [2-9]+    one or more numbers between 2-9.
- #$        '#' character at the end of input


## Running Tests

To run tests, run the following command

- Change application directory 
(E.g: ..\OldPhoneKeypadDemo\bin\Release\net8.0\)
- Run OldPhoneKeypadDemo.exe
- Enter key sequences (E.g: "33#")
- Related output message will be displayed. (E.g: "E" for "33#")


## Limitation
The limitation is you have to add space to separate subsequence same numeric keys to convert the correct letters, otherwise it could lead confusion of keys counts. E.g: If you want to send "HELLO" by using this app, you have to give inputs as "4433555 555666#". So that, can be considered 555 is "L". 

## Screenshot
![console-screenshot](https://github.com/user-attachments/assets/87bd2ca4-ee3d-4ef3-8da2-63678ff306c3)



