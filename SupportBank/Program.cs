namespace SupportBank
{

    class Program
    {
        static void Main(String[] args)
        {
            Bank b = new Bank();
            b.GetTransactionsFromFile("Transactions2014.csv");
            // b.PrintTransactions();
            // b.DisplayAccountList();
            // b.DisplayAllBalances();
            // Account a = b.AccountList.Find(x => x.Name == "Todd");
            // b.PrintTransactions(a);

                if (args[0].ToLower() != "list")
                {
                    b.DisplayAccountList();
                    return;
                }

                else
                {
                    if (!b.AccountList.Any (acc=>acc.Name.ToLower()==args[1].ToLower()))
                    {
                        throw new ArgumentOutOfRangeException("The given name does not match any account!");
                    }
                    else
                    {
                    Account a = b.AccountList.Find(x => x.Name.ToLower() == args[1].ToLower() );
                    b.PrintTransactions(a);
                    return;
                    }
                }

        }
            

    }
}
