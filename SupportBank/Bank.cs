namespace ShopInventory
{
    public class Bank
    {
        public List<Transaction> TransactionList {get; set;}
        
        public Bank ()
        {
            TransactionList = new List<Transaction>();
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
                }
                nr+=1;
            }
        }

        public void PrintTransactions ()
        {
            foreach (Transaction transaction in TransactionList)
            {
                transaction.PrintTransaction();
            }
            
        }


    }
}