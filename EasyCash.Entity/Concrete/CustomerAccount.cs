 namespace EasyCash.Entities.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string Currency { get; set; }
        public decimal Balance { get; set; }
        public string BankBranch { get; set; }

    }
}
