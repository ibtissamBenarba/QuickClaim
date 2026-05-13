namespace QuickClaim.API.Models
{
    public enum ExpenseStatus { Pending, Approved, Rejected }
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public DateTime Date { get; set; } = DateTime.UtcNow;
        public ExpenseStatus Status { get; set; } = ExpenseStatus.Pending;

        // For Multi-level: tracks who needs to act next
        public string CurrentApproverRole { get; set; } = "Manager";
    }
}
