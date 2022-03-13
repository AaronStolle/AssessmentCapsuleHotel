Console.Write(@"Welcome to Capsule-Capsule.
===========================
Enter the number of capsules available: ");
int RoomsTotal = PositiveNumValidation("");
string[] rooms = new string[RoomsTotal];
Console.Write(@$"
There are {RoomsTotal} unoccupied rooms ready to be booked.");

int GuestSelection = GuestMenuSelection(@"

Guest Menu
==========
1. Check In
2. Check Out
3. View Guests
4. Exit
Choose on option [1-4]: ");




static int GuestMenuSelection(string prompt)
{
    int GuestMenuChoice = 0;

    bool validChoice = false;


    do
    {
        Console.Write(prompt);
        GuestMenuChoice = PositiveNumValidation("");
        if (GuestMenuChoice > 4)
        {
            validChoice = false;
            Console.Write(@"
That Entry is invalid.");

        }
        else if (GuestMenuChoice == 1)
        {
            //Open Check In Method
            break;
        }
        else if (GuestMenuChoice == 2)
        {
            //Open Check Out Method
            break;
        }
        else if (GuestMenuChoice == 3)
        {
            //Open View Guests Method
            break;
        }
        else
        {
            validChoice = true;
            Exit("");
            Console.ReadLine();
            break;
        }
    } while (!validChoice);
    return GuestMenuChoice;
}



static string Exit(string prompt)
{
    Console.Write(@"
Exit
====
Are you sure you want to exit?
All data will be lost.
Exit [y/n]: ");
    
    string exitEntry = Console.ReadLine().ToLower();

    {
        if (exitEntry == "n")
        {
            GuestMenuSelection(@"
Guest Menu
==========
1. Check In
2. Check Out
3. View Guests
4. Exit
Choose on option [1-4]: ");
        }
        else if (exitEntry == "y")
        {
            Console.Write("\nGoodbye!");
        }
        else
        {
            Console.Write(@"
Invalid Entry!
Are you sure you want to exit: [y/n]: ");
        }

    } 
    return exitEntry;
}



static int PositiveNumValidation(string prompt)
{
    string input = null;

    bool validInput = false;

    input = Console.ReadLine();

    int result = 0; 

    do
    {
        Console.Write(prompt);
        if (int.TryParse(input, out result))
        {
            if (result > 0)
            {
                break;
            }
            else
            {
                Console.Write(@"
You must enter a positive number: ");
                input = Console.ReadLine();
            }

        }
        else
        {
            Console.Write(@"
You must a positive number: ");
            input = Console.ReadLine();
        }
    } while (!validInput);
    return result;
} 

