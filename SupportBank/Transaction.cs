namespace ShopInventory
{
    public class Transaction
    {
        public String AccountTo {get; set;}
        public String AccountFrom {get; set;}
        public String PaymentReference {get; set;}
        public float Amount {get; set;}
        public DateTime Date {get; set;}

        public Transaction (DateTime date, String accountFrom, String accountTo, String paymentReference, float amount)
        {
            Date=date;
            AccountFrom=accountFrom;
            AccountTo=accountTo;
            PaymentReference=paymentReference;
            Amount=amount;
        }

        public Transaction (String line)
        {
            string[] arr = line.Split(",");
            Date=arr[0];
            AccountFrom=arr[1];
            AccountTo=arr[2];
            PaymentReference=arr[3];
            Amount=arr[4];
            // foreach (string a in arr)
            // {
            //     Console.WriteLine(a);
            // }
            PrintTransaction();
        }
        public void PrintTransaction ()
        {
            Console.WriteLine("Date {0} From {1} To {2} Ref {3} Amount {4}:",Date.ToString("dd-MM-yyyy"),AccountFrom,AccountTo,PaymentReference,Amount);
        }
    }
}
