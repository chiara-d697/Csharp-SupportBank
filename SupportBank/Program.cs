namespace SupportBank
{

    class Program
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(String[] args)
        {
            
            Configuration c = new Configuration();
            c.SetLogFile(@"C:\Training\Csharp-SupportBank\SupportBank\log.log");
             
            Bank b = new Bank();
            //b.GetTransactionsFromFile("Transactions2014.csv");
            b.GetTransactions("DodgyTransactions2015.csv");


            //if (args.Count!=0)
            //{
                // if (args[0].ToLower() != "list")
                // {
                //     b.DisplayAccountList();
                //     return;
                // }

                // else
                // {
                //     if (!b.AccountList.Any (acc=>acc.Name.ToLower()==args[1].ToLower()))
                //     {
                //         throw new ArgumentOutOfRangeException("The given name does not match any account!");
                //     }
                //     else
                //     {
                //     Account a = b.AccountList.Find(x => x.Name.ToLower() == args[1].ToLower() );
                //     b.PrintTransactions(a);
                //     return;
                //     }
                // }
            //}
        }
            

    }
}
