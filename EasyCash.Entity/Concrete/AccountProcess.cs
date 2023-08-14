namespace EasyCash.Entities.Concrete
{
    public class AccountProcess
    {
        public int AccountProcessID { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }

    }
}
