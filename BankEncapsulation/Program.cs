namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Welcome to Bank Of Daylight Saves ATM!.....");
            

           


            while (true) 
            { 
              

              Console.WriteLine("1: Deposit money");
              Console.WriteLine("2: Check Balance");
              Console.WriteLine("3: Exit"); 
              
                int option;
                if(!int.TryParse(Console.ReadLine(), out option)) 
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;

                    
                        
                        
                }

                switch (option) 
                {
                    case 1:
                        Console.WriteLine("Enter the amount you want to deposit: ");
                        double amount;
                        if (!double.TryParse(Console.ReadLine(), out amount)) 
                        {
                            Console.WriteLine("Invaild input. Please enter vaild amount");
                            continue;
                        }
                           
                            account.deposit(amount);

                            Thread.Sleep(1000);
                            Console.WriteLine("You have deposit");
                            break;
                    case 2:
                            Console.WriteLine($"Account Balance: {account.GetBalance():C}");
                            break;
                    case 3:
                        Console.WriteLine("Thank You!!!");
                        return;
                    default:
                        Console.WriteLine("Invaild option. Please enter a vaild option. ");
                        break;
                }
            }



        }
    }
}
