namespace SupportBank
{

    public class CsvTransaction
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
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
            try
            {
                Date=DateTime.Parse(arr[0]);
            }
            catch (FormatException e)
            {
                Logger.Error(e, $"Date is not in valid format in line: {line}");
                throw new FormatException("Date is not in valid format", e);
            }

            AccountFrom=arr[1];
            AccountTo=arr[2];
            PaymentReference=arr[3];
            
            try
            {
                Amount=decimal.Parse(arr[4]);
                //Logger.Info($"File line: {line}");
            }
            catch (FormatException e)
            {
                Logger.Error(e, $"Amount of money is not in valid format in line: {line}");
                throw new FormatException("Amount of money is not in valid format", e);
            }
        }
        public void PrintTransaction ()
        {
            Console.WriteLine("Date {0} From {1} To {2} Ref {3} Amount {4}",Date.ToString("dd-MM-yyyy"),AccountFrom,AccountTo,PaymentReference,string.Format("{0:c}",Amount));
        }
    }
}