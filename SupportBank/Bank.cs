namespace SupportBank
{
    public class Bank
    {
        public List<Transaction> TransactionList {get; set;}
        public List<Account> AccountList {get; set;}
        
        public Bank()
        {
            TransactionList = new List<Transaction>();
            AccountList = new List<Account>();
        }

        public void GetTransactionsFromFile(String fileName) 
        {
            string[] lines = File.ReadAllLines(fileName);
            int nr=0;
            foreach (string line in lines) 
            {
                if (nr!=0)
                {
                    Transaction transaction = new Transaction (line);    
                    TransactionList.Add(transaction);
                    AddToAccountList(transaction);    
                }
                nr+=1;
            }
        }
 
        public void AddToAccountList(Transaction transaction)
        {
            
        }

        public void PrintTransactions ()
        {
            foreach (Transaction transaction in TransactionList)
            {
                transaction.PrintTransaction();
            }
            
        }

        public void DisplayAccountList()
        {
            foreach (Account account in AccountList)
            {
                account.DisplayAccountName();
            }
        }


    }
}