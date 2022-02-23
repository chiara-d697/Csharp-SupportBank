namespace SupportBank
{
    public class Account
    {
        public String Name {get; set;}

        public Account(String name)
        {
            Name = name;
        }

        public void DisplayAccountName()
        {
            Console.WriteLine(Name);
        }

        // public void DisplayBalance(Bank bank)
        // {
        //     Console.WriteLine("Name {0} Tatal balance = {1}",Name,GetTotal(bank));
        // }

        // public float GetTotalIncome(Bank bank)
        // {
        //     float total=0;
        //     foreach (Transaction transaction in bank.TransactionList)
        //     {
        //         if (transaction.AccountTo==Name)
        //             total+=transaction.Amount;
        //     };
        //     return total;
        // }

        // public float GetTotalOutcome(Bank bank)
        // {
        //     float total=0;
        //     foreach (Transaction transaction in bank.TransactionList)
        //     {
        //         if (transaction.AccountFrom==Name)
        //             total+=transaction.Amount;
        //     };
        //     return total;
        // }

        // public float GetTotal(Bank bank)
        // {
        //     return GetTotalIncome(bank)-GetTotalOutcome(bank);
        // }

    }
}