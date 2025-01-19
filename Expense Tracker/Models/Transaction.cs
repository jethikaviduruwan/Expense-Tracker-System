using System.ComponentModel.DataAnnotations;

namespace Expense_Tracker.Models
{
    public class Transaction
    {
        [Key]
        public int transactionId { get; set; }

        //Category ID

        public int Amount { get; set; }

        public int categoryIdId { get; set; }
        public Category Category { get; set; }
        
        public string? Note { get; set; }

        public DateTime DateTime { get; set; } = DateTime.Now;
    }
}
