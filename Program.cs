// Welcome Message
Console.WriteLine("******* Welcome to the Basic ATM Simulation *******");

//Declare global variables
int accBalance = 1000;
int cashWithdraw = 0;
int pinAttempts = 3;

// Create a DateTime from currenct timestamp
DateTime date = new DateTime();

int accPin;
while(true)
{
//Ask user for pin
Console.Write($"Please enter your PIN (You have {pinAttempts} attempts left): ");
accPin = Convert.ToInt32(Console.ReadLine());

// Pin validation and ATM menu
if (accPin == 1234)
{
    Console.WriteLine("Corect Pin");
    break;
}
else
{
        pinAttempts--;
        if (pinAttempts == 0)
        {
        Console.WriteLine("Too many wrong attempts. Goodbye");
        return;
        }
} 
}

while (true) 
{
    // Show ATM options 
    Console.WriteLine("Please select an operation");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Exit");

    // Read user input
    Console.Write("Enter your choice: ");
    int option = Convert.ToInt32(Console.ReadLine());

    // Exit operation
    if (option == 4)
    {
        Console.WriteLine("Exiting ATM thank you");
        return;
    } 
   

    // Switch statement based on the option menu
    switch (option)
            {
                case 1: // Check balance
                    Console.WriteLine($"Your balance is: ${accBalance}");
                     DateTime now1 = DateTime.Now; //create a date now varible within each case 
                    Console.WriteLine("The Time Now Is: " + now1);                    
                    break;

                case 2: // Withdraw
                    Console.Write("Enter withdrawal amount: ");
                    int withdrawAmount = Convert.ToInt32(Console.ReadLine());

                    if (withdrawAmount > accBalance || withdrawAmount < 0) //validate
                    {
                        Console.WriteLine("Insufficient balance or inserted negative number. Please try again");
                    }
                    else
                    {
                        accBalance -= withdrawAmount;
                        Console.WriteLine($"Withdrawal successful! Current balance: ${accBalance}");

                         DateTime now2 = DateTime.Now;
                        Console.WriteLine("The time now is: " + now2);                    
                    }
                    break;

                case 3: // Deposit
                    Console.Write("Enter deposit amount: ");
                    int depositAmount = Convert.ToInt32(Console.ReadLine());

                    if (depositAmount < 0) //validate
                    {
                        Console.WriteLine("Can't depsoit negative funds! Please try again");
                    }
                    else
                    {
                        accBalance += depositAmount;
                        Console.WriteLine($"Depsot successful! Current balance: ${accBalance}");

                         DateTime now3 = DateTime.Now;
                        Console.WriteLine("The time now is: " + now3);                    
                    }

                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
               // Pause before clearing screen
            Console.WriteLine("Press Enter to go back to main menu");
            Console.ReadLine();
            Console.Clear();
}


Console.WriteLine("************************** End of ATM simulator program *****************************");


