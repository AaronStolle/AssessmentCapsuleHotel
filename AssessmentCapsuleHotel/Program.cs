string input = null;

bool validInput = false;


Console.Write(@"Welcome to Capsule-Capsule.
===========================
Enter the number of capsules available: ");
input = Console.ReadLine();

do
{
    if (int.TryParse(input, out int result))
    {
        if (result > 0)
        {
            string[] rooms = new string[result];
            Console.Write(@$"
There are {result} unoccupied rooms ready to be booked.");
            // open the main menu
            break;
        }
        else
        {
            Console.Write(@"
Your input must be a positive number!
Enter the number of rooms available: ");
            input = Console.ReadLine();
        }

    }
    else
    {
        Console.Write(@"
Your input must be a positive number!
Enter the number of rooms available: ");
        input = Console.ReadLine();
    }
} while (!validInput);


