/*
 * Software by TheMasterCoder007 - 2025
 *
 * Program:
 *  Addition Calculator
 *
 * Assignment Details:
 *  Create a simple console calculator that takes in two integers and returns the sum. The course does not
 *  require the program to handle exceptions such as if the user give no input or a invalid input such as a decimal
 *  number, or letter.
 *
 * Program Improvements (Not Required by Course):
 *  1. Error handling
 *  2. Allow numbers larger than a int to be processed
 *  3. Allow decimal numbers
 *
 */

// program title and instructions
Console.WriteLine("*** MasterC's Addition Calculator ***");
Console.WriteLine("Enter 'q' at anytime to quit the program\n");

// run calculator until user selects quit
while (true) {
    // instructions
    Console.WriteLine("Please enter a number. Press enter after each number entry:");
    
    // first input
    var input1 = Console.ReadLine();
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    if (input1 == "q") break;

    if (decimal.TryParse(input1, out var number1)) {
        Console.Write(number1 + " + ");
    } else {
        Console.WriteLine("You entered a incorrect value. Please start again\n");
        continue;
    }
     
    // second input
    var input2 = Console.ReadLine();
    Console.SetCursorPosition(0, Console.CursorTop - 1);
    if (input2 == "q") break;

    if (decimal.TryParse(input2, out var number2)) {
        Console.Write(number1 + " + " + number2 + " = ");
    } else {
        Console.WriteLine("You entered a incorrect value. Please start again\n");
        continue;
    }
     
    // answer
    var sum = number1 + number2;
    Console.Write(sum + "\n\n");
}

// end program
Console.WriteLine("Program now quitting...");