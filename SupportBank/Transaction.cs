namespace SupportBank
{
    public class Transaction
    {
        public String AccountTo {get; set;}
        public String AccountFrom {get; set;}
        public String PaymentReference {get; set;}
        public decimal Amount {get; set;}
        public DateTime Date {get; set;}

        public Transaction (DateTime date, String accountFrom, String accountTo, String paymentReference, decimal amount)
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
            Date=DateTime.Parse(arr[0]);
            AccountFrom=arr[1];
            AccountTo=arr[2];
            PaymentReference=arr[3];
            Amount=decimal.Parse(arr[4]);
        }
        public void PrintTransaction ()
        {
            Console.WriteLine("Date {0} From {1} To {2} Ref {3} Amount {4}",Date.ToString("dd-MM-yyyy"),AccountFrom,AccountTo,PaymentReference,string.Format("{0:c}",Amount));
        }
    }
}
