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

        public void GetTransactions(string[] lines)
        {   
            int nr=0;
            foreach (string line in lines) 
            {
                if (nr!=0)
                {
                    Transaction transaction = new Transaction (line);    
                    TransactionList.Add(transaction);
                    AddToAccountList(transaction.AccountFrom); 
                    AddToAccountList(transaction.AccountTo);    
                }
                nr+=1;
            } 
        }
        public void AddToAccountList(String accountName)
        {
            int x=0;
            foreach (Account a in AccountList)
            {
                if (a.Name==accountName) 
                    x+=1;
            }
            if (x==0)
            {
                Account account = new Account(accountName);
                AccountList.Add(account);
            }
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

        public void PrintTransactions (Account account)
        {
            foreach (Transaction transaction in TransactionList)
            {
                if (account.Name==transaction.AccountFrom || account.Name==transaction.AccountTo)
                    transaction.PrintTransaction();
            }
            
        }
        public void DisplayAllBalances()
        {
            foreach (Account account in AccountList)
            {
                Console.WriteLine("Name {0} Total balance = {1}",account.Name, string.Format("{0:c}",GetTotalBalance(account))); 
            }
        }

        public void DisplayBalance(Account account)
        {
            Console.WriteLine("Name {0} Total balance = {1}",account.Name, string.Format("{0:c}",GetTotalBalance(account))); 
        }

        public decimal GetTotalBalance(Account account)
        {
            decimal total=0;
            foreach (Transaction transaction in TransactionList)
            {
                if (transaction.AccountTo==account.Name)
                    total+=transaction.Amount;
                if (transaction.AccountFrom==account.Name)
                    total-=transaction.Amount;
            };
            return total;
        }

    }
}