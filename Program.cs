Console.WriteLine("******* Welcome to the Basic ATM Simulation *******");

int accBalance = 1000;
int cashWithdraw = 0;
int pinAttempts = 3;

DateTime date = new DateTime();

int accPin;
while(true)
{

Console.Write($"Please enter your PIN (You have {pinAttempts} attempts left): ");
accPin = Convert.ToInt32(Console.ReadLine());

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
    
    Console.WriteLine("Please select an operation");
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw");
    Console.WriteLine("3. Deposit");
    Console.WriteLine("4. Exit");

    Console.Write("Enter your choice: ");
    int option = Convert.ToInt32(Console.ReadLine());

    
    if (option == 4)
    {
        Console.WriteLine("Exiting ATM thank you");
        return;
    } 
   
    switch (option)
            {
                case 1: // Check balance
                    Console.WriteLine($"Your balance is: ${accBalance}");                   
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
                        Console.WriteLine($"The time now is: {now2.ToString("dd/MM/yyyy")}");                    
                    }
                    break;

                case 3: // Deposit
                    Console.Write("Enter deposit amount: ");
                    int depositAmount = Convert.ToInt32(Console.ReadLine());

                    if (depositAmount < 0) 
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
               
            Console.WriteLine("Press Enter to go back to main menu");
            Console.ReadLine();
            Console.Clear();
}


Console.WriteLine("************************** End of ATM simulator program *****************************");


