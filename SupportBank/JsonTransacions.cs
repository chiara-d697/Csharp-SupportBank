namespace SupportBank
{

public class JsonTransaction
    {
        //private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        //public DateTime Date {get; set;}
        public String Date {get; set;}
        public String FromAccount {get; set;}
        public String ToAccount {get; set;}
        public String Narrative {get; set;}
        public String Amount {get; set;}
        //public decimal Amount {get; set;}

        // public JsonTransaction(DateTime date, String fromAccount, String toAccount, String narrative, decimal amount)
        // {
        //     Date = date;
        //     FromAccount = fromAccount;
        //     ToAccount = toAccount;
        //     Narrative = narrative;
        //     Amount = amount;
        // }

        public JsonTransaction(String date, String fromAccount, String toAccount, String narrative, String amount)
        {
            Date = date;
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Narrative = narrative;
            Amount = amount;
        }
    }
}