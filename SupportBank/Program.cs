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

            CsvLoader loaderC = new CsvLoader();
            string[] lines = loaderC.FileLoader("Transactions2014.csv");
            b.GetTransactions(lines);

            JsonLoader loaderJ = new JsonLoader();
            lines = loaderJ.FileLoader("Transactions2013.json");
            b.GetTransactions(lines);

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
                b.DisplayBalance(a);
                return;
                }
            }
        }
            

    }
}
