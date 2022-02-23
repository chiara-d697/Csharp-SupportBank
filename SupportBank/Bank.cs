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
                    // string[] arr = line.Split(",");
                    // foreach (string a in arr)
                    // {
                    //     Console.WriteLine(a);
                    // }
                    Transaction transaction = new Transaction (line);
                        
                }
                nr+=1;
            }
        }


    }
}