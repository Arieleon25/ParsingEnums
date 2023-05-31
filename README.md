# ParsingEnums

The ParsingEnums project is a console application that demonstrates the parsing of user input into an enum data type in C#. It includes the definition of an enum for the days of the week and the use of a try/catch block to handle errors when parsing user input.

# Project Description

The ParsingEnums project consists of two files: Program.cs and Utils.cs.

Program.cs

This file contains the Program class, which contains the Main method. In the Main method, the program prompts the user to enter the current day of the week. It then attempts to parse the user input into the enum data type DayOfWeekEnum using the Enum.Parse method.

The program wraps the parsing statement in a try/catch block to handle any errors that may occur during the parsing process. If an error occurs, it catches the exception and prints the message "Please enter an actual day of the week." to the console.

Utils.cs

This file contains utility methods used by the program, such as a method to display the prompt message to the user and read their input.

Instructions

Start the console application.

The program will display a prompt asking you to enter the current day of the week.

Enter the current day of the week as a string (e.g., "Monday", "Tuesday", etc.) and press Enter.

The program will attempt to parse the user input into the DayOfWeekEnum data type.

If the parsing is successful, the program will assign the parsed value to a variable of the DayOfWeekEnum type.

If an error occurs during the parsing process, the program will catch the exception and print the message "Please enter an actual day of the week." to the console.

The program will terminate.

You can rerun the program to test different inputs and observe the error handling.

# Skills Demonstrated
This project demonstrates the following skills and concepts related to parsing enums in C#:

Defining and using enums to represent a set of values

Parsing user input into an enum data type using Enum.Parse

Handling errors using try/catch blocks
