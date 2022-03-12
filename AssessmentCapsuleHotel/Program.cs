Console.Write(@"Welcome to Capsule-Capsule.
===========================
Enter the number of capsules available: ");
int RoomsTotal = PositiveNumValidation("");
string[] rooms = new string[RoomsTotal];
Console.Write(@$"
There are {RoomsTotal} unoccupied rooms ready to be booked.");

static int GuestMenuSelection(string prompt)
{
    int GuestMenuChoice = 0;

    bool validChoice = false;


    do
    {
        Console.Write(@"
Guest Menu
==========
1. Check In
2. Check Out
3. View Guests
4. Exit
Choose on option [1-4]: ");
        GuestMenuChoice = PositiveNumValidation("");
        if (GuestMenuChoice > 4)
        {
            Console.Write(@"That Entry is invalid.
Please Enter a choice between 1-4: ");

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
            //Open Exit Method
            break;
        }
    } while (!validChoice);
    return GuestMenuChoice;
}

int GuestSelection = GuestMenuSelection("");
Console.WriteLine($"Your choice was: {GuestSelection}");


static int PositiveNumValidation(string prompt)
{
    string input = null;

    bool validInput = false;

    input = Console.ReadLine();

    int result = 0; 

    do
    {
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

