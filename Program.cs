namespace ATM_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal currentBal = 101235;

            Console.Write("Enter the amount you wish to withdraw: ");

            if (!decimal.TryParse(Console.ReadLine(), out decimal amountWithdraw))
            {
                Console.WriteLine("You must enter a numeric value!");
            }
            else if(amountWithdraw <= 0)
            {
                Console.WriteLine("Amount must be greater than zero!");
            }
            else if (amountWithdraw>currentBal)
            {
                Console.WriteLine("Insufficient funds!");
            }
            else
            {
                decimal newCurrentBal = currentBal -= amountWithdraw;
                Console.WriteLine($"Withdrawal successful!\n Your remaining balance is: {newCurrentBal}");
            }
         
        }
    }
}
