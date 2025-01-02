using System.Transactions;

namespace ExpenseTrackerApp.Models
{
    public class AppData
    {
        public List<User> Users { get; set; } = new();

        public List<Debt> Debts { get; set; } = new();

        public List<Transaction> Transactions { get; set; } = new();

    }
}
