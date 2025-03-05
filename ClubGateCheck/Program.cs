/*
// * Software by TheMasterCoder007 - 2025
// *
// * Program:
// *  Club Gate Check
// *
// * Assignment Details:
// *  Create a simple console program that decides if the person can enter the club.
// *
// * Program Improvements (Not Required by Course):
// *  1. Error handling
// *  2. Take parents name if child is required to be accompanied by parents
// *  3. Print ticket to console
// *
// */

// program introduction
Console.WriteLine("Welcome to the Continental Club!\n\n");

// get users age
var age = GetUsersAge();

// check age against requirements
if (age >= 18) {
    Console.WriteLine("Please enter your name:");
    var name = GetName();
    PrintTicket(name, age);
} else if (age >= 13) {
    Console.WriteLine("Are you with a parent/guardian? Please enter 'y' or 'n':");
    if (Console.ReadLine() is "y" or "Y") {
        Console.WriteLine("Please enter your name:");
        var name = GetName();
        Console.WriteLine("Please enter your parents name:");
        var parentsName = GetName();
        PrintTicket(name, age, parentsName);
    } else {
        Console.WriteLine("I'm sorry, but you do not meet the requirements for this club\n\n");
    }
} else {
    Console.WriteLine("I'm sorry, but you do not meet the age requirements for this club\n\n");
}

// end program
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
return;

//***********************************************************************************************
// HELPER METHODS
//***********************************************************************************************

static int GetUsersAge() {
    Console.WriteLine("Please enter your age:");
    
    var age = 0;
    var validAgeEntered = false;
    while (!validAgeEntered) {
        validAgeEntered = int.TryParse(Console.ReadLine(), out age);
    }

    return age;
}

static string GetName() {
    string? name = null;
    while (name is null) {
        name = Console.ReadLine();
    }

    return name;
}

static void PrintTicket(string name, int age, string? parentsName = null) {
    Console.WriteLine("\nPrinting Ticket....\n");
    Console.WriteLine("**********************");
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    if (parentsName is not null) {
        Console.WriteLine($"Parent's Name: {parentsName}");
    }
    Console.WriteLine("**********************");
    Console.WriteLine("\n");
}