namespace ShopInventory
{
    class Program
    {
        static void Main(String[] args)
        {
            Bank b = new Bank();
            b.GetTransactionsFromFile("Transactions2014.csv");
        }
    }
}
