namespace SupportBank
{
    public class Account
    {
        public String Name {get; set;}

        public Account(String name)
        {
            Name = name;
        }

        public void DisplayAccountName()
        {
            Console.WriteLine(Name);
        }


    }
}